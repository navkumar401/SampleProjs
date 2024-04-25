using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using iOSBindingSample;

namespace iOSBindingSample
{

    [BaseType(typeof(NSObject))]
    interface UPCA
    {
        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // @property (assign, nonatomic) BOOL enableCheckDigit;
        [Export("enableCheckDigit")]
        bool EnableCheckDigit { get; set; }

        // @property (assign, nonatomic) BOOL enableNumberSystem;
        [Export("enableNumberSystem")]
        bool EnableNumberSystem { get; set; }

        // @property (assign, nonatomic) BOOL enable2DigitAddenda;
        [Export("enable2DigitAddenda")]
        bool Enable2DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enable5DigitAddenda;
        [Export("enable5DigitAddenda")]
        bool Enable5DigitAddenda { get; set; }

        // @property (assign, nonatomic) BOOL requireAddenda;
        [Export("requireAddenda")]
        bool RequireAddenda { get; set; }

        // @property (assign, nonatomic) BOOL enableAddendaSeparator;
        [Export("enableAddendaSeparator")]
        bool EnableAddendaSeparator { get; set; }

        // @property UPCA_EAN13_ExtendedCouponCode extendedCouponCode;
        [Export("extendedCouponCode", ArgumentSemantic.Assign)]
        UPCA_EAN13_ExtendedCouponCode ExtendedCouponCode { get; set; }
    }

}
