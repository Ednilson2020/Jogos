using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;

public class AdmobManager : MonoBehaviour
{

    public static AdmobManager instance;
    public int deaths;
    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardBasedVideoAd rewardBasedVideoAd;
    private string idReward;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID
        string appId = "ca-app-pub-2592578753291775~5032111547";
        idReward = "ca-app-pub-2592578753291775/8340801169";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-9785533804332092~9517523520";
#else
            string appId = "unexpected_platform";
#endif

        MobileAds.Initialize(appId);
        //   MobileAds.Initialize(initStatus => { });
        rewardBasedVideoAd = RewardBasedVideoAd.Instance;
        rewardBasedVideoAd.OnAdRewarded += HandleOnRewardedAdLoaded;
        //
      

        //
        RequestBanner();
      //  RequestInterstitial();
        //RequestRewardBasedVideo();

    }

    public void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-2592578753291775/4693307990";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
        Invoke("DestroyBanner", 10f);
    }

    void DestroyBanner()
    {
        bannerView.Destroy();
    }
    void DestroyInterstitial()
    {
        interstitial.Destroy();
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-2592578753291775/7438783037";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif
        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
        Invoke("DestroyInterstitial", 10f);
    }

    void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        RequestInterstitial();
    }

    public void ShowPopUp()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }



    //video
    public void HandleOnRewardedAdLoaded(object sender, EventArgs args)
    {//ad loaded
        ShowRewardAd();

    }
    public void HandleOnAdRewarded(object sender, EventArgs args)
    {//user finished watching ad
      //  int points = int.Parse(TxtPoints.text);
     //   points += 50; //add 50 points
       // TxtPoints.text = points.ToString();
    }
    public void HandleOnRewardedAdClosed(object sender, EventArgs args)
    {//ad closed (even if not finished watching)
      //  BtnReward.interactable = true;
//BtnReward.GetComponentInChildren<Text>().text = "More Points";

      //  adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
       // adReward.OnAdRewarded -= this.HandleOnAdRewarded;
       // adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;
    }

    public void RequestRewardAd()
    {
        AdRequest request = AdRequestBuild();
        rewardBasedVideoAd.LoadAd(request, idReward);

        rewardBasedVideoAd.OnAdLoaded += this.HandleOnRewardedAdLoaded;
        rewardBasedVideoAd.OnAdRewarded += this.HandleOnAdRewarded;
        rewardBasedVideoAd.OnAdClosed += this.HandleOnRewardedAdClosed;
    }
    public void ShowRewardAd()
    {
        if (rewardBasedVideoAd.IsLoaded())
            rewardBasedVideoAd.Show();
    }
     public void MostrarVideo()
    {
        //BtnReward.interactable = false;
       // BtnReward.GetComponentInChildren<Text>().text = "Loading...";
        RequestRewardAd();
    }

    //------------------------------------------------------------------------
    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();
    }

    void OnDestroy()
    {
        rewardBasedVideoAd.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
        rewardBasedVideoAd.OnAdRewarded -= this.HandleOnAdRewarded;
        rewardBasedVideoAd.OnAdClosed -= this.HandleOnRewardedAdClosed;
    }


}