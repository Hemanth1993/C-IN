using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1ILDGen
{
    public class CConf
    {
        #region Static Methods
        /// <summary>
        /// Gets a string from the configuration file.
        /// </summary>
        /// <param name="key">Configuration name.</param>
        /// <returns>The String associated to the configuration.</returns>
        public static String GetString(String key)
        {
            return (GetSetting(key));
        }

        /// <summary>
        /// Gets an int from the configuration file.
        /// </summary>
        /// <param name="key">Configuration name.</param>
        /// <returns>The int associated to the configuration.</returns>
        public static int GetInt(string key)
        {
            return (Convert.ToInt32(GetSetting(key)));
        }
        /// <summary>
        /// Gets a Boolean from the configuration file.
        /// </summary>
        /// <param name="key">Configuration name.</param>
        /// <returns>The Boolean associated to the configuration.</returns>
        public static Boolean GetBoolean(string key)
        {
            return (Convert.ToBoolean(GetSetting(key)));
        }

        /// <summary>
        /// Get a float from the configuration file
        /// </summary>
        /// <param name="key">Configuration name.</param>
        /// <returns>The Float associated to the configuration.</returns>
        public static float GetFloat(string key)
        {
            return (Convert.ToSingle(GetSetting(key)));
        }

        /// <summary>
        /// Gets a value in the configuratin file.
        /// </summary>
        /// <param name="key">Configuration to get.</param>
        /// <returns>The value of the configuration.</returns>
        protected static String GetSetting(String key)
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            try
            {
                return (((string)(configurationAppSettings.GetValue(key, typeof(string)))));
            }
            catch (InvalidOperationException)
            {
                return (null);
            }
        }
        #endregion

    }
}
