using Kount.Ris;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace KountRisTest
{
    
    public class ConfigurationTest
    {
        public Configuration SUT;

        [Fact]
        public void Setup()
        {
            SUT = Configuration.FromAppSettings();
        }

        [Fact]
        public void FromAppSettings_assigns_Connect_Timeout()
        {
            Assert.Equal(SUT.ConnectTimeout, "10000");
        }

        [Fact]
        public void FromAppSettings_assigns_MerchantId()
        {
            Assert.Equal(SUT.MerchantId, "000000");
        }

        [Fact]
        public void FromAppSettings_assigns_API_Key()
        {
            Assert.Equal(SUT.ApiKey, "");
        }

        [Fact]
        public void FromAppSettings_assigns_Version()
        {
            Assert.Equal(SUT.Version, "0695");
        }

        [Fact]
        public void FromAppSettings_assigns_Url()
        {
            Assert.Equal(SUT.URL, "https://risk.beta.kount.net");
        }

        [Fact]
        public void FromAppSettings_assigns_CertificateFile()
        {
            Assert.Equal(SUT.CertificateFile, "certificate.pfx");
        }

        [Fact]
        public void FromAppSettings_assigns_PrivateKeyPassword()
        {
            Assert.Equal(SUT.PrivateKeyPassword, "11111111111111111");
        }

        [Fact]
        public void FromAppSettings_assigns_ConfigKey()
        {
            Assert.Equal(SUT.ConfigKey, null);
        }
    }
}
