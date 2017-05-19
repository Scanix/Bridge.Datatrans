using Bridge;
using System;

namespace Bridge.Datatrans
{
    [External]
    [ObjectLiteral]
    public class ThemeConfigurationOptions
    {
        /// <summary>
        /// The color of your brand.
        /// </summary>
        /// <value>hex notation of a color</value>
        public string BrandColor;

        /// <summary>
        /// The color of the text in the header bar if no logo is given.
        /// </summary>
        /// <value>'white' | 'black'</value>
        public string TextColor;

        /// <summary>
        /// An SVG image (scalability) provided by the merchant. The image needs to be uploaded by using the Datatrans Web Administration Tool.
        /// </summary>
        public string LogoSrc;

        /// <summary>
        /// The header logo's display style.
        /// </summary>
        /// <value>'circle' | 'rectangle' | 'none'</value>
        public string LogoType;

        /// <summary>
        /// Decides whether the logo shall be styled with a border around it, if the value is true the default background color is chosen, else the provided string is used as color value.
        /// </summary>
        public string LogoBorderColor;

        /// <summary>
        /// If true, the pay button will have the same color as specified for brandColor. Otherweise the provided string is used as a coor value.
        /// </summary>
        public bool BrandButton;

        /// <summary>
        /// The color of the pay button text.
        /// </summary>
        public string payButtonTextColor;

        /// <summary>
        /// Wheter the payment page shows the payment method selection as list (default) or as a grid.
        /// </summary>
        public string initialView;
    }
}