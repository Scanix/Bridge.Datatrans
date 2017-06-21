using Bridge;
using System;

namespace Bridge.Datatrans
{
    [External]
    [ObjectLiteral]
    public class DatatransOptions
    {
        public string Form;

        public DatatransParamsOptions Params;

        /// <summary>
        /// The callback to invoke when the payment page is opened.
        /// </summary>
        public Action Opened;

        /// <summary>
        /// The callback to invoke when the payment page is loaded.
        /// </summary>
        public Action Loaded;

        /// <summary>
        /// The callback to invoke when the payment page is closed.
        /// </summary>
        public Action Closed;

        public ThemeConfigurationOptions ThemeConfiguration;
    }
}