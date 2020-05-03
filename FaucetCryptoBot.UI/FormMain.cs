/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaucetCryptoBot.Engine;
using FaucetCryptoBot.Engine.Concrete;
using FaucetCryptoBot.Engine.Entities;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace FaucetCryptoBot.UI
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// FaucetCryptoBot
        /// </summary>
        private readonly FaucetCryptoBotApi _faucetCryptoBotApi;
        private bool _isLogin = false;
        public static Thread ServiceThread;
        private static bool _isServiceStatus = false;
        private static bool _isReadyToClaim = false;
        private static bool _isPtcAdsProcess = false;
        private static bool _isShortLinksProcess = false;
        public static double BalanceFirst = 0;



        public FormMain()
        {
            InitializeComponent();

            // FaucetCryptoBot Api
            _faucetCryptoBotApi = new FaucetCryptoBotApi(
                "JLxNOaaTCtzgiePoCEUfBAlJciEblcp6XOvqf1Izn0vC",
                "https://api.eu-gb.speech-to-text.watson.cloud.ibm.com/instances/2560dab5-3ae6-4e89-a543-7cbdabf85b9b"
                );
        }


        /// <summary>
        /// Form Load
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// Timer saniyeyi göstermek için donma var mı kontrol ediyorum
        /// </summary>
        private async void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "FaucetCrypto Bot - " + DateTime.Now.ToString("T");
            await GetAdsInfo();
        }

        /// <summary>
        /// Reklam bilgilerini çekip aktarma
        /// </summary>
        /// <returns></returns>
        private async Task GetAdsInfo()
        {
            try
            {
                if (_isLogin)
                {
                    await Task.Run(async () =>
                    {
                        // Bilgileri aktar
                        var result = await _faucetCryptoBotApi.CurrentDetailsInfo();

                        // Balance
                        double balance = _faucetCryptoBotApi.HelperService.ConvertToDouble(result.Balance);

                        // İlk kazanç
                        if (BalanceFirst <= 0)
                        {
                            BalanceFirst = balance;
                            tbxBalanceFirst.Text = BalanceFirst.ToString(CultureInfo.InvariantCulture);
                        }

                        // Mevcut Kazanç
                        tbxBalanceCurrent.Text = balance.ToString(CultureInfo.InvariantCulture);

                        // Kazanç
                        var balanceWon = Convert.ToDouble(balance) - (BalanceFirst);
                        tbxBalanceWon.Text = balanceWon.ToString(CultureInfo.InvariantCulture);


                        // Ready to Claim
                        tbxAdsInfoReadyToClaim.Text = result.ReadyToClaimWaitingTime;
                        if (result.ReadyToClaimActive == false)
                        {
                            _isReadyToClaim = false;
                        }
                        else
                        {
                            _isReadyToClaim = true;
                        }


                        //Short Links
                        tbxAdsInfoShortLinks.Text = result.ShortLinksCount;
                        if (tbxAdsInfoShortLinks.Text == "0" || int.Parse(tbxAdsInfoShortLinks.Text) < 4)
                        {
                            _isShortLinksProcess = false;
                        }
                        else
                        {
                            _isShortLinksProcess = true;
                        }


                        // Archievements
                        tbxAdsInfoAchievements.Text = result.AchievementsCount;

                        // Ptc ads
                        tbxAdsInfoPtcAds.Text = result.PtcAdsCount;
                        if (tbxAdsInfoPtcAds.Text == "0")
                        {
                            _isPtcAdsProcess = false;
                        }
                        else
                        {
                            _isPtcAdsProcess = true;
                        }

                        toolStatusLabel.Text = "Ads bilgileri çekildi";
                    });
                }
                else
                {
                    // Önce temizle
                    tbxAdsInfoReadyToClaim.Clear();
                    tbxAdsInfoShortLinks.Clear();
                    tbxAdsInfoAchievements.Clear();
                    tbxAdsInfoPtcAds.Clear();
                    tbxBalanceFirst.Clear();
                    tbxBalanceCurrent.Clear();
                    tbxBalanceWon.Clear();
                }
            }
            catch
            {
                // ignore
            }
        }
        
        /// <summary>
        /// Siteye giriş yap butonu
        /// </summary>
        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnBrowserQuit.Enabled = true;

            var userParam = new LoginProperty
            {
                Username = tbxEmail.Text,
                Password = tbxPassword.Text
            };

            var loginResult = await _faucetCryptoBotApi.Login(userParam);
            lblStatus.Text = loginResult.Message;
            toolStatusLabel.Text = loginResult.Message;
            if (loginResult.Code == ResponseStatus.Success)
            {
                BalanceFirst = 0;
                _isLogin = true;
                grpbxApiService.Enabled = true;
            }
        }

        /// <summary>
        /// Api token bilgilerini aktar
        /// </summary>
        private void btnApiSetToken_Click(object sender, EventArgs e)
        {
            _faucetCryptoBotApi.SetApiToken(tbxApiAuthorization.Text);
            tabControl.SelectedTab = tabServices;
        }

        /// <summary>
        /// Tarayıcıyı kapatma butonu
        /// </summary>
        private void btnBrowserQuit_Click(object sender, EventArgs e)
        {
            _isLogin = false;
            btnBrowserQuit.Enabled = false;
            btnLogin.Enabled = true;
            _faucetCryptoBotApi.Logout();
        }

        /// <summary>
        /// Log kaydı oluşturma
        /// </summary>
        /// <param name="value"></param>
        private void AddLog(string value)
        {
            var result = "[" + DateTime.Now.ToString("T") + "] " + value;
            lstbxLogs.Items.Insert(0, result);
        }
        
        /// <summary>
        /// Reklam servislerini başlatma
        /// </summary>
        private void btnServicesStart_Click(object sender, EventArgs e)
        {
            if (_isServiceStatus == false)
            {
                // nesne aktiflikleri
                btnServicesStart.Enabled = false;
                btnServicesStop.Enabled = true;
                _isServiceStatus = true;
                toolStatusLabel.Text = "Reklam Servisleri Başladı";
                AddLog("Reklam Servisleri Başladı");

                ServiceThread = new Thread(() =>
                {
                    try
                    {
                        ServicesEngine();
                    }
                    catch (Exception exception)
                    {
                        AddLog("ServiceStart: " + exception.Message);
                        //MessageBox.Show("ServiceStart: " + exception.Message);
                    }
                    finally
                    {
                        AddLog("ServiceStart Finish");
                        //MessageBox.Show("ServiceStart Finish");
                    }
                });
                ServiceThread.Start();
            }
            else
            {
                toolStatusLabel.Text = "Reklam Servisleri Başlamadı.";
            }
        }

        /// <summary>
        /// Reklam servislerini durdurma
        /// </summary>
        private void btnServicesStop_Click(object sender, EventArgs e)
        {
            if (!_isServiceStatus) return;

            // nesne aktiflikleri
            btnServicesStart.Enabled = true;
            btnServicesStop.Enabled = false;
            _isServiceStatus = false;
            toolStatusLabel.Text = "Reklam Servisleri Durduruldu";
            AddLog("Reklam Servisleri Durduruldu");
            ServiceThread.Abort();
        }

        /// <summary>
        /// Servis motoru
        /// </summary>
        private void ServicesEngine()
        {
            while (true)
            {
                if (!_isServiceStatus) return;

                var serviceList = lstbxServices.CheckedItems;
                foreach (string service in serviceList)
                {
                    // Ready to Claim
                    if (service == "Ready to Claim" && tbxAdsInfoReadyToClaim.Text == "Aktif" && _isReadyToClaim)
                    {
                        AddLog("Ready to Claim: Başladı");
                        _faucetCryptoBotApi.ReadyToClaimProcess();
                        AddLog("Ready to Claim: Bitti");
                    }

                    // ShortLinks
                    else if (service == "ShortLinks" && tbxAdsInfoShortLinks.Text != "0" && _isShortLinksProcess)
                    {
                        AddLog("ShortLinks: Başladı");
                        _faucetCryptoBotApi.ShortLinksProcess();
                        AddLog("ShortLinks: Bitti");
                    }

                    // Ptc Ads
                    else if (service == "Ptc Ads" && tbxAdsInfoPtcAds.Text != "0" && _isPtcAdsProcess)
                    {
                        while (_isPtcAdsProcess)
                        {
                            AddLog("Ptc Ads: Başladı");
                            _faucetCryptoBotApi.PtcAdsProcess();
                            AddLog("Ptc Ads: Bitti");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Test butonu
        /// </summary>
        private void btnTester_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
