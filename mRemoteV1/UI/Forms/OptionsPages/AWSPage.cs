using System;
using System.IO;
using System.Windows.Forms;
using mRemoteNG.App;
using mRemoteNG.App.Info;
using mRemoteNG.Config.Putty;
using mRemoteNG.Connection.Protocol;
using mRemoteNG.Tools;
using System.Collections.Generic;

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public partial class AWSPage
    {
        public AWSPage()
        {
            InitializeComponent();
        }

        #region Public Methods

        public override string PageName
        {
            get { return "AWS"; }
            set { }
        }

        public override void ApplyLanguage()
        {
            base.ApplyLanguage();
        }

        public override void LoadSettings()
        {
            base.SaveSettings();

            chkEuWest1.Checked = Settings.Default.AwsRegions.Contains("eu-west-1");
            chkEuWest2.Checked = Settings.Default.AwsRegions.Contains("eu-west-2");
            chkEuCentral1.Checked = Settings.Default.AwsRegions.Contains("eu-central-1");
            chkUsEast1.Checked = Settings.Default.AwsRegions.Contains("us-east-1");
            chkUsEast2.Checked = Settings.Default.AwsRegions.Contains("us-east-2");
            chkUsWest1.Checked = Settings.Default.AwsRegions.Contains("us-west-1");
            chkUsWest2.Checked = Settings.Default.AwsRegions.Contains("us-west-2");
            chkCaCentral1.Checked = Settings.Default.AwsRegions.Contains("ca-central-1");
            chkApSouth1.Checked = Settings.Default.AwsRegions.Contains("ap-south-1");
            chkApNorthEast1.Checked = Settings.Default.AwsRegions.Contains("ap-northeast-1");
            chkApNorthEast2.Checked = Settings.Default.AwsRegions.Contains("ap-northeast-2");
            chkApSouthEast1.Checked = Settings.Default.AwsRegions.Contains("ap-southeast-1");
            chkApSouthEast2.Checked = Settings.Default.AwsRegions.Contains("ap-southeast-2");
            chkSaEast1.Checked = Settings.Default.AwsRegions.Contains("sa-east-1");
        }

        public override void SaveSettings()
        {
            var regions = new List<string>();
            if (chkEuWest1.Checked)
            {
                regions.Add("eu-west-1");
            }
            if (chkEuWest2.Checked)
            {
                regions.Add("eu-west-2");
            }
            if (chkEuCentral1.Checked)
            {
                regions.Add("eu-central-1");
            }
            if (chkUsEast1.Checked)
            {
                regions.Add("us-east-1");
            }
            if (chkUsEast2.Checked)
            {
                regions.Add("us-east-2");
            }
            if (chkUsWest1.Checked)
            {
                regions.Add("us-west-1");
            }
            if (chkUsWest2.Checked)
            {
                regions.Add("us-west-2");
            }
            if (chkCaCentral1.Checked)
            {
                regions.Add("ca-central-1");
            }
            if (chkApSouth1.Checked)
            {
                regions.Add("ap-south-1");
            }
            if (chkApNorthEast1.Checked)
            {
                regions.Add("ap-northeast-1");
            }
            if (chkApNorthEast2.Checked)
            {
                regions.Add("ap-northeast-2");
            }
            if (chkApSouthEast1.Checked)
            {
                regions.Add("ap-southeast-1");
            }
            if (chkApSouthEast2.Checked)
            {
                regions.Add("ap-southeast-2");
            }
            if (chkSaEast1.Checked)
            {
                regions.Add("sa-east-1");
            }

            Settings.Default.AwsRegions = string.Join(",", regions);

            Settings.Default.Save();
        }

        #endregion
    }
}