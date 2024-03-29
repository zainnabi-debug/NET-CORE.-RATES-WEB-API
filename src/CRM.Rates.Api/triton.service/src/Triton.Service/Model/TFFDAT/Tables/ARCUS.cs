﻿using Dapper.Contrib.Extensions;

namespace Triton.Service.Model.TFFDAT.Tables
{
    [Table("ARCUS")]
    public class ARCUS
    {
        public string IDCUST { get; set; }
        public decimal AUDTDATE { get; set; }
        public decimal AUDTTIME { get; set; }
        public string AUDTUSER { get; set; }
        public string AUDTORG { get; set; }
        public string TEXTSNAM { get; set; }
        public string IDGRP { get; set; }
        public string IDNATACCT { get; set; }
        public short SWACTV { get; set; }
        public decimal DATEINAC { get; set; }
        public decimal DATELASTMN { get; set; }
        public short SWHOLD { get; set; }
        public decimal DATESTART { get; set; }
        public string IDPPNT { get; set; }
        public string CODEDAB { get; set; }
        public string CODEDABRTG { get; set; }
        public decimal DATEDAB { get; set; }
        public string NAMECUST { get; set; }
        public string TEXTSTRE1 { get; set; }
        public string TEXTSTRE2 { get; set; }
        public string TEXTSTRE3 { get; set; }
        public string TEXTSTRE4 { get; set; }
        public string NAMECITY { get; set; }
        public string CODESTTE { get; set; }
        public string CODEPSTL { get; set; }
        public string CODECTRY { get; set; }
        public string NAMECTAC { get; set; }
        public string TEXTPHON1 { get; set; }
        public string TEXTPHON2 { get; set; }
        public string CODETERR { get; set; }
        public string IDACCTSET { get; set; }
        public string IDAUTOCASH { get; set; }
        public string IDBILLCYCL { get; set; }
        public string IDSVCCHRG { get; set; }
        public string IDDLNQ { get; set; }
        public string CODECURN { get; set; }
        public short SWPRTSTMT { get; set; }
        public short SWPRTDLNQ { get; set; }
        public short SWBALFWD { get; set; }
        public string CODETERM { get; set; }
        public string IDRATETYPE { get; set; }
        public string CODETAXGRP { get; set; }
        public string IDTAXREGI1 { get; set; }
        public string IDTAXREGI2 { get; set; }
        public string IDTAXREGI3 { get; set; }
        public string IDTAXREGI4 { get; set; }
        public string IDTAXREGI5 { get; set; }
        public short TAXSTTS1 { get; set; }
        public short TAXSTTS2 { get; set; }
        public short TAXSTTS3 { get; set; }
        public short TAXSTTS4 { get; set; }
        public short TAXSTTS5 { get; set; }
        public decimal AMTCRLIMT { get; set; }
        public decimal AMTBALDUET { get; set; }
        public decimal AMTBALDUEH { get; set; }
        public decimal DATELASTST { get; set; }
        public decimal AMTLASTSTT { get; set; }
        public decimal AMTLASTSTH { get; set; }
        public decimal DTBEGBALFW { get; set; }
        public decimal AMTBALFWDT { get; set; }
        public decimal AMTBALFWDH { get; set; }
        public decimal DTLASTRVAL { get; set; }
        public decimal AMTBALLARV { get; set; }
        public decimal CNTOPENINV { get; set; }
        public decimal CNTINVPAID { get; set; }
        public decimal DAYSTOPAY { get; set; }
        public decimal DATEINVCHI { get; set; }
        public decimal DATEBALHI { get; set; }
        public decimal DATEINVHIL { get; set; }
        public decimal DATEBALHIL { get; set; }
        public decimal DATELASTAC { get; set; }
        public decimal DATELASTIV { get; set; }
        public decimal DATELASTCR { get; set; }
        public decimal DATELASTDR { get; set; }
        public decimal DATELASTPA { get; set; }
        public decimal DATELASTDI { get; set; }
        public decimal DATELASTAD { get; set; }
        public decimal DATELASTWR { get; set; }
        public decimal DATELASTRI { get; set; }
        public decimal DATELASTIN { get; set; }
        public decimal DATELASTDQ { get; set; }
        public string IDINVCHI { get; set; }
        public string IDINVCHILY { get; set; }
        public decimal AMTINVHIT { get; set; }
        public decimal AMTBALHIT { get; set; }
        public decimal AMTINVHILT { get; set; }
        public decimal AMTBALHILT { get; set; }
        public decimal AMTLASTIVT { get; set; }
        public decimal AMTLASTCRT { get; set; }
        public decimal AMTLASTDRT { get; set; }
        public decimal AMTLASTPYT { get; set; }
        public decimal AMTLASTDIT { get; set; }
        public decimal AMTLASTADT { get; set; }
        public decimal AMTLASTWRT { get; set; }
        public decimal AMTLASTRIT { get; set; }
        public decimal AMTLASTINT { get; set; }
        public decimal AMTINVHIH { get; set; }
        public decimal AMTBALHIH { get; set; }
        public decimal AMTINVHILH { get; set; }
        public decimal AMTBALHILH { get; set; }
        public decimal AMTLASTIVH { get; set; }
        public decimal AMTLASTCRH { get; set; }
        public decimal AMTLASTDRH { get; set; }
        public decimal AMTLASTPYH { get; set; }
        public decimal AMTLASTDIH { get; set; }
        public decimal AMTLASTADH { get; set; }
        public decimal AMTLASTWRH { get; set; }
        public decimal AMTLASTRIH { get; set; }
        public decimal AMTLASTINH { get; set; }
        public string CODESLSP1 { get; set; }
        public string CODESLSP2 { get; set; }
        public string CODESLSP3 { get; set; }
        public string CODESLSP4 { get; set; }
        public string CODESLSP5 { get; set; }
        public decimal PCTSASPLT1 { get; set; }
        public decimal PCTSASPLT2 { get; set; }
        public decimal PCTSASPLT3 { get; set; }
        public decimal PCTSASPLT4 { get; set; }
        public decimal PCTSASPLT5 { get; set; }
        public string PRICLIST { get; set; }
        public short CUSTTYPE { get; set; }
        public decimal AMTPDUE { get; set; }
        public string EMAIL1 { get; set; }
        public string EMAIL2 { get; set; }
        public string WEBSITE { get; set; }
        public short BILLMETHOD { get; set; }
        public string PAYMCODE { get; set; }
        public string FOB { get; set; }
        public string SHPVIACODE { get; set; }
        public string SHPVIADESC { get; set; }
        public short DELMETHOD { get; set; }
        public string PRIMSHIPTO { get; set; }
        public string CTACPHONE { get; set; }
        public string CTACFAX { get; set; }
        public short SWPARTSHIP { get; set; }
        public short SWWEBSHOP { get; set; }
        public decimal RTGPERCENT { get; set; }
        public short RTGDAYS { get; set; }
        public string RTGTERMS { get; set; }
        public decimal RTGAMTTC { get; set; }
        public decimal RTGAMTHC { get; set; }
        public int VALUES { get; set; }
        public decimal CNTPPDINVC { get; set; }
        public decimal AMTPPDINVT { get; set; }
        public decimal AMTPPDINVH { get; set; }
        public decimal DATELASTRF { get; set; }
        public decimal AMTLASTRFT { get; set; }
        public decimal AMTLASTRFH { get; set; }
        public string CODECHECK { get; set; }
        public int NEXTCUID { get; set; }
        public string LOCATION { get; set; }
        public short SWCHKLIMIT { get; set; }
        public short SWCHKOVER { get; set; }
        public short OVERDAYS { get; set; }
        public decimal OVERAMT { get; set; }
        public short SWBACKORDR { get; set; }
        public short SWCHKDUPPO { get; set; }
        public short CATEGORY { get; set; }
        public string BRN { get; set; }
    }
}
