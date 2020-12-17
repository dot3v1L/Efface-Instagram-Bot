using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using CefSharp;
using CefSharp.Wpf;
using Microsoft.Win32;
using WindowsInput;
using Efface_Instagram_Bot.Help;

namespace Efface_Instagram_Bot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser browserprimary = new ChromiumWebBrowser("https://accounts.google.com/ServiceLogin?passive=true&service=youtube&uilel=3&continue=https%3A%2F%2Fwww.youtube.com%2F");
        ChromiumWebBrowser browsersecondary = new ChromiumWebBrowser("https://www.instagram.com/accounts/login/");
        InputSimulator keysimulator = new InputSimulator();
        bool IsWorking = false;
        int PostsCount = 100;
        private int seePosts = 0;
        private bool seeLimitPhotos;
        Random rnd = new Random();
       
        public MainWindow()
        {
            InitializeComponent();
            BrowserContainerPrimary.Children.Add(browserprimary);
            BrowserContainerSecondary.Children.Add(browsersecondary);
            System.Diagnostics.Process.Start("https://in4.bz/");
        }

        private async void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1500);

            browserprimary.Focus();

            browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[name ^= 'username']\")[0].focus();");


            keysimulator.Keyboard.TextEntry(Emailbox.Text);

            await Task.Delay(3000);

            browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[name ^= 'password']\")[0].focus();");


            keysimulator.Keyboard.TextEntry(Passwordbox.Password);

            await Task.Delay(3000);


            browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[type ^= 'submit']\")[0].click();");

        }

        private async void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            IsWorking = true;
            StartBtn.IsEnabled = false;
            StopBtn.IsEnabled = true;


            if (IsWorking == true)
            {

                if (ToggleByUsername.IsChecked == true)
                    browserprimary.Address = "https://www.instagram.com/" + Usernamebox.Text;

                
            else if (ToggleByHashtag.IsChecked == true)
            {
                browserprimary.Address = "https://www.instagram.com/explore/tags/" + Usernamebox.Text;
            }


            await Task.Delay(5000);

            if(seeLimitPhotos)
                PostsCount = Int32.Parse(TLimitPhoto.Text);


            while (seePosts < PostsCount)
            {
                    browserprimary.ExecuteScriptAsync("document.getElementsByClassName('v1Nh3 kIKUG  _bz0w')[" + seePosts + "].children[0].click();");

                    await Task.Delay(3000);

                    if (ToggleLike.IsChecked == true)
                    {

                        browserprimary.ExecuteScriptAsync("document.querySelector('[aria-label=\"Like\"]').parentElement.click();"); //document.querySelectorAll(\"[aria-label ^= 'Like']\")[0].click();

                        await Task.Delay(3000);

                    }

                    if (ToggleUnlike.IsChecked == true)
                    {


                        browserprimary.ExecuteScriptAsync("document.querySelectorAll([aria-label=\"Unlike\"]).parentElement.click();"); // document.querySelectorAll(\"[aria-label ^= 'Unlike']\")[0].click();

                        await Task.Delay(3000);



                    }


                    if (ToggleComment.IsChecked == true && ListBoxComment.Items.Count > 0)
                    {


                        browserprimary.Focus();


                        browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[aria-label ^= 'Add a comment…']\")[0].focus();");

                        await Task.Delay(1500);

                        string comment = "";
                        string smile = "";
                        if (CheckRandomText.IsChecked ?? true)
                        {
                            comment = Randomizer.Parse(ListBoxComment.Items[rnd.Next(0, ListBoxComment.Items.Count)]
                                .ToString());
                        }

                        if (UseSmile.IsChecked ?? true)
                        {
                            smile = Smiles.GetSmile(rnd.Next(0, 7), LoveSmile.IsChecked, FlowSmile.IsChecked,
                                FruitSmile.IsChecked, CatSmile.IsChecked, FaceSmile.IsChecked);
                        }
                        else
                        {
                            comment = ListBoxComment.Items[rnd.Next(0, ListBoxComment.Items.Count)]
                                .ToString();
                        }

                        if (ToggleMention.IsChecked == true)
                        {
                            
                            keysimulator.Keyboard.TextEntry($"{comment}{smile} {MentionsBox.Text}");
                            await Task.Delay(1500);

                            browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[aria-label ^= 'Add a comment…']\")[0].nextSibling.click();");

                        }
                        else
                        {
                            keysimulator.Keyboard.TextEntry($"{comment}{smile}");

                            await Task.Delay(1500);

                            browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[aria-label ^= 'Add a comment…']\")[0].nextSibling.click();");
                        }



                        await Task.Delay(3000);

                    }


                    if (ToggleFollow.IsChecked == true)
                    {


                        browserprimary.ExecuteScriptAsync("for (var i = 0; i < document.querySelectorAll(\"[type ^= 'Button']\").length; i++) { if (document.querySelectorAll(\"[type ^= 'Button']\")[i].innerText == \"Follow\") { document.querySelectorAll(\"[type ^= 'Button']\")[i].click(); } }");

                        await Task.Delay(2000);



                    }

                    if (ToggleUnfollow.IsChecked == true)
                    {

                        browserprimary.ExecuteScriptAsync("for (var i = 0; i < document.querySelectorAll(\"[type ^= 'Button']\").length; i++) { if (document.querySelectorAll(\"[type ^= 'Button']\")[i].innerText == \"Following\") { document.querySelectorAll(\"[type ^= 'Button']\")[i].click(); } }");

                        await Task.Delay(2000);

                        browserprimary.ExecuteScriptAsync("document.getElementsByClassName('mt3GC')[0].children[0].click();");

                        await Task.Delay(2000);




                    }

                    browserprimary.ExecuteScriptAsync("document.querySelectorAll(\"[role ^= 'dialog']\")[0].click();");

                    await Task.Delay(2000);

                    seePosts++;

                    browserprimary.ExecuteScriptAsync("window.scrollBy(0,200)");
                }

             browserprimary.Address = "https://www.instagram.com/";
            }


        }

        private void ToggleByUsername_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ToggleByHashtag.IsChecked = false;

            }
            catch
            {

            }
        }

        private void ToggleByHashtag_Checked(object sender, RoutedEventArgs e)
        {
            ToggleByUsername.IsChecked = false;
        }

        private void ToggleFollow_Checked(object sender, RoutedEventArgs e)
        {
            ToggleUnfollow.IsChecked = false;
        }

        private void ToggleUnfollow_Checked(object sender, RoutedEventArgs e)
        {
            ToggleFollow.IsChecked = false;
        }

        private void ToggleLike_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                ToggleUnlike.IsChecked = false;
            }
            catch
            {

            }

        }

        private void ToggleUnlike_Checked(object sender, RoutedEventArgs e)
        {
            ToggleLike.IsChecked = false;
        }

        private void ImportBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (OpenFileDialog.ShowDialog() == true)
            {
                var Mentionfile = File.ReadAllText(OpenFileDialog.FileName);
                MentionsBox.Text = Mentionfile;
            }

               
            
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (SaveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(SaveFileDialog.FileName, MentionsBox.Text);
            }
        }

        private async void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            PostsCount = 1;
            IsWorking = false;
            StopBtn.IsEnabled = false;
            StartBtn.IsEnabled = true;
            BrowserContainerPrimary.Children.Remove(browserprimary);
            BrowserContainerSecondary.Children.Remove(browsersecondary);
            await Task.Delay(1000);
            BrowserContainerPrimary.Children.Add(browserprimary);
            BrowserContainerSecondary.Children.Add(browsersecondary);
            browserprimary.Address = "https://www.instagram.com";
            browsersecondary.Address = "https://www.instagram.com";

        }

        private void ToggleMention_Checked(object sender, RoutedEventArgs e)
        {
            if (ToggleComment.IsChecked == true)
            {
                ToggleMention.IsChecked = true;
            }
            else
            {
                ToggleMention.IsChecked = false;
            }
        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            if (ToggleComment.CheckAccess())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        string[] comment = File.ReadAllLines(openFileDialog.FileName);
                        for (int i = 0; i < comment.Length; i++)
                        {
                            ListBoxComment.Items.Add(comment[i]);
                        }
                    }
                }
                else
                {
                    ToggleComment.IsChecked = false;
                }
            }
        }

        private void CheckLimitPhoto_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckLimitPhoto.IsChecked == true)
            {
                seeLimitPhotos = true;
                TLimitPhoto.IsEnabled = true;
            }
            else
            {
                seeLimitPhotos = false;
                TLimitPhoto.IsEnabled = false;
            }
                
        }

        private void UseSmile_Checked(object sender, RoutedEventArgs e)
        {
            if (UseSmile.CheckAccess())
            {
                if (UseSmile.IsChecked ?? true)
                {
                    LoveSmile.IsEnabled = true;
                    FaceSmile.IsEnabled = true;
                    FlowSmile.IsEnabled = true;
                    CatSmile.IsEnabled = true;
                    FruitSmile.IsEnabled = true;
                }
            }
        }

        private void UseSmile_OnUnchecked(object sender, RoutedEventArgs e)
        {
            LoveSmile.IsEnabled = false;
            FaceSmile.IsEnabled = false;
            FlowSmile.IsEnabled = false;
            CatSmile.IsEnabled = false;
            FruitSmile.IsEnabled = false;
            LoveSmile.IsChecked = false;
            FaceSmile.IsChecked = false;
            FlowSmile.IsChecked = false;
            CatSmile.IsChecked = false;
            FruitSmile.IsChecked = false;
        }
    }
}
