using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aliasBit.Utils
{
    public static class Constants
    {
        public const string DELETE_MESSAGE = "Record deleted successfully.";
        public const string SAVE_MESSAGE = "Record saved successfully.";

        public const int APP_TYPE_STRING = 1;
        public const int APP_TYPE_NUMBER = 2;
        public const int APP_TYPE_DATETIME = 3;
        public const int APP_TYPE_BOOLEAN = 4;
        public const int APP_TYPE_CURRENCY = 5;
        public const int APP_TYPE_PERCENTAGE = 6;
        public const int APP_TYPE_TIME = 8;

        public const int TOTAL_TYPE_COUNT = 1;
        public const int TOTAL_TYPE_SUM = 2;
        public const int TOTAL_TYPE_AVG = 3;
        public const int TOTAL_TYPE_MIN = 4;
        public const int TOTAL_TYPE_MAX = 5;
        public const int TOTAL_TYPE_NONE = 0;

        public const int SHAPETYPE_VECTOR = 1;
        public const int SHAPETYPE_LABEL = 2;

        public const int MAP_WIDTH = 520;
        public const int MAP_HEIGHT = 480;

        public const string ENC_PASSPHRASE = "ADHOC_APPLICATION_PASS_KEY";
    }
}
