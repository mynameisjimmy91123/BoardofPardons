
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BoardofPardons.Entity
{

using System;
    using System.Collections.Generic;
    
public partial class NonIncarceratedStep2
{

    public int Id { get; set; }

    public int FormId { get; set; }

    public System.DateTime DateINC { get; set; }

    public string ConvictCounty { get; set; }

    public string ConvictOTN { get; set; }

    public string ConvictDocket { get; set; }

    public string Guilty { get; set; }

    public string DateSentence { get; set; }

    public string ConvictJudge { get; set; }

    public string Offenses { get; set; }

    public string Sentence { get; set; }

    public string NotGuilty { get; set; }

    public string Facts { get; set; }

    public bool HavePaid { get; set; }

    public string FinesBalance { get; set; }

    public Nullable<System.DateTime> LastPaymentDate { get; set; }

    public Nullable<bool> ViolatedParole { get; set; }

    public Nullable<bool> ParoleRevoked { get; set; }

    public Nullable<bool> RevokedAppeal { get; set; }

    public string CourtAppeal { get; set; }

    public string Codefendents { get; set; }

    public Nullable<System.DateTime> CreatedAt { get; set; }

    public Nullable<System.DateTime> UpdatedAt { get; set; }



    public virtual Form Form { get; set; }

}

}
