using Microsoft.Owin;
using Microsoft.Owin.Security.Twitter;
using Owin;

namespace TwitterBackupRestAPI.App_Start
{
    public partial class Startup
    {
        /// <summary>
        /// For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        /// </summary>
        /// <param name="app"></param>
        public void ConfigureAuth(IAppBuilder app)
        {
            app = ConfigureTwitter(app);
        }

        /// <summary>
        /// Current Configuration Update all necessary settings for Twitter.
        /// Articles: http://www.oauthforaspnet.com/providers/twitter/ and 
        /// http://www.asp.net/mvc/overview/security/create-an-aspnet-mvc-5-app-with-facebook-and-google-oauth2-and-openid-sign-on
        /// 
        /// Twitter credentials should be stored in: <see cref="Security/AppSettingsSecrets.config"/>.
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        private IAppBuilder ConfigureTwitter(IAppBuilder app)
        {
            string TwitterCallbackPath = ClientConfigurations.AppSettings.Setting<string>("TwitterCallbackURL");

            var options = new TwitterAuthenticationOptions
            {
                ConsumerKey = ClientConfigurations.AppSettings.Setting<string>("TwitterConsumerKey"),
                ConsumerSecret = ClientConfigurations.AppSettings.Setting<string>("TwitterConsumerKey"),
                CallbackPath = new PathString(TwitterCallbackPath)
            };

            return app;
        }
    }
}
