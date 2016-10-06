using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Text;
#pragma warning disable 649

namespace Microsoft.Bot.Sample.DiaRBot
{
     
    public enum Sex
    {
        Unkown, Male, Female

    };

    public enum AgeCat
    {
        Unkown, Lessthansixteen, Sixteentothirtyfive, Thirtyfiveandabove

    };

    public enum NofKids
    {
        Unkown, Zero, Onetofour, Fiveandabove

    };

    public enum Abortion
    {
        Unkown, Yes, No

    };

    public enum PostPartumHemorrhage
    {
        Unkown, Yes, No

    };

    public enum BabysWeight
    {
        Unkown, Greaterthanfour, Lessthantwoandahalf

    };

    public enum PregHtn
    {
        Unkown, Yes, No

    };
    public enum Infertility
    {
        Unkown, Yes, No

    };
    public enum PrevCSec
    {
        Unkown, Yes, No

    };
    public enum StillBirth
    {
        Unkown, Yes, No

    };
    public enum DiffLabor
    {
        Unkown, Yes, No

    };
    public enum Bleeding
    {
        Unkown, Lessthantwenty, Greaterthantwenty
        
    };
    public enum Anemia
    {
        Unkown, Yes, No
        //Hb less than 10 g

    };
    public enum Hypertension
    {
        Unkown, Yes, No

    };
    public enum Edema
    {
        Unkown, Yes, No

    };
    public enum Albuminuria
    {
        Unkown, Yes, No

    };
    public enum MultiplePreg
    {
        Unkown, Yes, No

    };
    public enum Breech
    {
        Unkown, Yes, No

    };
    public enum RHImmuniz
    {
        Unkown, Yes, No

    };
    public enum ProlongedLabor
    {
        Unkown, Yes, No

    };
    public enum PremRuptMemb
    {
        Unkown, Yes, No

    };
    public enum Polyhydraminos
    {
        Unkown, Yes, No

    };
    public enum SmallFetus
    {
        Unkown, Yes, No

    };
    public enum Diabetes
    {
        Unkown, Yes, No

    };
    public enum CardiacDis
    {
        Unkown, Yes, No

    };
    public enum PrevGynSurg
    {
        Unkown, Yes, No

    };
    public enum CRD
    {
        Unkown, Yes, No

    };
    public enum InfHep
    {
        Unkown, Yes, No

    };
    public enum PulTub
    {
        Unkown, Yes, No

    };
    public enum OtherDis
    {
        Unkown, Yes, No

    };
    public enum UndNut
    {
        Unkown, Yes, No

    };


    [Serializable]
    class GetDetails
    {
        public Sex sex;
        [Prompt("Please select your sex? {||}")]
        [Describe("Sex is an essential factor in determining your diabetes risk.")]
        public AgeCat agecat;
        public NofKids nofkids;
        public Abortion abortion;
        public PostPartumHemorrhage postparthem;
        public BabysWeight babysweight;
        public PregHtn preghtn;
        public Infertility infertility;
        public PrevCSec prevcsec;
        public StillBirth stillbirth;
        public DiffLabor difflabor;
        public Bleeding bleeding;
        public Anemia anemia;
        public Hypertension hypertension;
        public Edema edema;
        public Albuminuria albuminuria;
        public MultiplePreg multiplepreg;
        public Breech breech;
        public RHImmuniz rhimmuniz;
        public ProlongedLabor prolongedlabor;
        public PremRuptMemb premruptmemb;
        public Polyhydraminos polyhydraminos;
        public SmallFetus smallfetus;
        public Diabetes diabetes;
        public CardiacDis cardiacdis;
        public PrevGynSurg prevgynsurg;
        public CRD crd;
        public InfHep infhep;
        public PulTub pultub;
        public OtherDis otherdis;
        public UndNut undnut;

        public override string ToString()
        {
            var builder = new StringBuilder();
            //            builder.AppendFormat("GetBenefits({0}, ", sex);
            //            switch (sex)
            //{
            //   case Sex.Male:
            //builder.AppendFormat("GetBenefits({0}, ",  mabo);
            //break;
            //    case Sex.Female:
            //builder.AppendFormat("GetBenefits({0}, ", fabo);
            //break;
            //}

            builder.AppendFormat("GetBenefits({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31}, ", sex, agecat, nofkids, abortion, postparthem, babysweight, preghtn, infertility, prevcsec, stillbirth, difflabor, bleeding, anemia, hypertension, edema, albuminuria, multiplepreg, breech, rhimmuniz, prolongedlabor, premruptmemb, polyhydraminos, smallfetus, diabetes, cardiacdis, prevgynsurg, crd, infhep, pultub, otherdis, undnut);
            return builder.ToString();
        }
    };
}

