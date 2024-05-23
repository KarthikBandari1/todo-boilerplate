using todo3.Debugging;

namespace todo3
{
    public class todo3Consts
    {
        public const string LocalizationSourceName = "todo3";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6f0ecd4501f147ba8b36975222122b16";
    }
}
