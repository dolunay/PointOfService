﻿using System;

namespace PointOfService.Hardware
{
    public enum BarcodeSymbology
    {
        Unknown = 0,
        Upca = 101,
        Upce = 102,
        EanJan8 = 103,
        EanJan13 = 104,
        TF = 105,
        Itf = 106,
        Codabar = 107,
        Code39 = 108,
        Code93 = 109,
        Code128 = 110,
        Upcas = 111,
        Upces = 112,
        Upcd1 = 113,
        Upcd2 = 114,
        Upcd3 = 115,
        Upcd4 = 116,
        Upcd5 = 117,
        Ean8S = 118,
        Ean13S = 119,
        Ean128 = 120,
        Ocra = 121,
        Ocrb = 122,
        Code128Parsed = 123,
        Gs1DataBar = 131,
        [Obsolete("Replaced by Gs1DataBar")] Rss14 = 131,
        Gs1DataBarExpanded = 132,
        [Obsolete("Replaced by Gs1DataBarExpanded")] RssExpanded = 132,
        Gs1DataBarStackedOmnidirectional = 133,
        ItfCK = 133,
        Gs1DataBarExpandedStacked = 134,
        Gs1DataBar_Type2 = 134,
        Ames = 135,
        TFMAT = 136,
        Code39Ck = 137,
        Code32 = 138,
        CodeCIP = 139,
        TriOptic39 = 140,
        ISBT128 = 141,
        Code11 = 142,
        MSI = 143,
        Plessey = 144,
        Telepen = 145,
        Cca = 151,
        Ccb = 152,
        Ccc = 153,
        Tlc39 = 154,
        Pdf417 = 201,
        Maxicode = 202,
        DataMatrix = 203,
        QRCode = 204,
        MicroQRCode = 205,
        Aztec = 206,
        MicroPDF417 = 207,
        Gs1DataMatrix = 208,
        Gs1QRCode = 209,
        Code49 = 210,
        Code16k = 211,
        CodablockA = 212,
        CodablockF = 213,
        Codablock256 = 214,
        HANXIN = 215,
        AusPost = 301,
        CanPost = 302,
        ChinaPost = 303,
        DutchKix = 304,
        InfoMail = 305,
        JapanPost = 306,
        KoreanPost = 307,
        SwedenPost = 308,
        UkPost = 309,
        UsIntelligent = 310,
        UsPlanet = 311,
        PostNet = 312,
        Other = 501
    }
}
