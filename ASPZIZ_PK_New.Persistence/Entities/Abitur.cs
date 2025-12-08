using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Abitur")]
public partial class Abitur
{
    [Key]
    [Column("abiturId")]
    public Guid AbiturId { get; set; }

    [Column("regStep")]
    public byte? RegStep { get; set; }

    [Column("dateCreated", TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    [Column("dateUpdated", TypeName = "datetime")]
    public DateTime DateUpdated { get; set; }

    [Column("abtCode")]
    [StringLength(50)]
    public string? AbtCode { get; set; }

    [Column("fam")]
    [StringLength(255)]
    public string Fam { get; set; } = null!;

    [Column("im")]
    [StringLength(255)]
    public string Im { get; set; } = null!;

    [Column("otch")]
    [StringLength(255)]
    public string? Otch { get; set; }

    [Column("dataRogd", TypeName = "smalldatetime")]
    public DateTime? DataRogd { get; set; }

    [Column("polB")]
    public bool? PolB { get; set; }

    [Column("pasTypeId")]
    public byte PasTypeId { get; set; }

    [Column("pasInoe")]
    [StringLength(255)]
    public string? PasInoe { get; set; }

    [Column("pasLichNomer")]
    [StringLength(15)]
    public string? PasLichNomer { get; set; }

    [Column("pasSer")]
    [StringLength(10)]
    public string? PasSer { get; set; }

    [Column("pasNom")]
    [StringLength(20)]
    public string? PasNom { get; set; }

    [Column("pasData", TypeName = "smalldatetime")]
    public DateTime? PasData { get; set; }

    [Column("pasKemVidan")]
    [StringLength(255)]
    public string? PasKemVidan { get; set; }

    [Column("obrUrovId")]
    public byte ObrUrovId { get; set; }

    [Column("obrUchId")]
    public byte ObrUchId { get; set; }

    [Column("obrDokTypeId")]
    public byte ObrDokTypeId { get; set; }

    [Column("obrDokNomer")]
    [StringLength(20)]
    public string? ObrDokNomer { get; set; }

    [Column("obrUchrCode")]
    [StringLength(200)]
    public string? ObrUchrCode { get; set; }

    [Column("obrDataOkon", TypeName = "smalldatetime")]
    public DateTime? ObrDataOkon { get; set; }

    [Column("obrPodgOtdelB")]
    public bool ObrPodgOtdelB { get; set; }

    [Column("obrInYaz")]
    [StringLength(50)]
    public string? ObrInYaz { get; set; }

    [Column("telKodGoroda")]
    [StringLength(10)]
    public string? TelKodGoroda { get; set; }

    [Column("telDom")]
    [StringLength(30)]
    public string? TelDom { get; set; }

    [Column("telMob")]
    [StringLength(30)]
    public string? TelMob { get; set; }

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("semejnoePologB")]
    public bool? SemejnoePologB { get; set; }

    [Column("obschB")]
    public bool ObschB { get; set; }

    [Column("otecTipRodstva")]
    [StringLength(50)]
    public string? OtecTipRodstva { get; set; }

    [Column("otecFam")]
    [StringLength(255)]
    public string? OtecFam { get; set; }

    [Column("otecIm")]
    [StringLength(255)]
    public string? OtecIm { get; set; }

    [Column("otecOtch")]
    [StringLength(255)]
    public string? OtecOtch { get; set; }

    [Column("otecAddr")]
    [StringLength(400)]
    public string? OtecAddr { get; set; }

    [Column("otecRabota")]
    [StringLength(300)]
    public string? OtecRabota { get; set; }

    [Column("matTipRodstva")]
    [StringLength(50)]
    public string? MatTipRodstva { get; set; }

    [Column("matFam")]
    [StringLength(255)]
    public string? MatFam { get; set; }

    [Column("matIm")]
    [StringLength(255)]
    public string? MatIm { get; set; }

    [Column("matOtch")]
    [StringLength(255)]
    public string? MatOtch { get; set; }

    [Column("matAddr")]
    [StringLength(400)]
    public string? MatAddr { get; set; }

    [Column("matRabota")]
    [StringLength(300)]
    public string? MatRabota { get; set; }

    [Column("adrIndeks")]
    [StringLength(10)]
    public string? AdrIndeks { get; set; }

    [Column("adrStrana")]
    [StringLength(50)]
    public string? AdrStrana { get; set; }

    [Column("adrOblast")]
    [StringLength(50)]
    public string? AdrOblast { get; set; }

    [Column("adrRajon")]
    [StringLength(50)]
    public string? AdrRajon { get; set; }

    [Column("adrNasPunktTip")]
    [StringLength(50)]
    public string? AdrNasPunktTip { get; set; }

    [Column("adrNasPunktName")]
    [StringLength(50)]
    public string? AdrNasPunktName { get; set; }

    [Column("adrUlTip")]
    [StringLength(50)]
    public string? AdrUlTip { get; set; }

    [Column("adrUlName")]
    [StringLength(100)]
    public string? AdrUlName { get; set; }

    [Column("adrDomNom")]
    [StringLength(50)]
    public string? AdrDomNom { get; set; }

    [Column("adrDomKorp")]
    [StringLength(50)]
    public string? AdrDomKorp { get; set; }

    [Column("adrDomKv")]
    [StringLength(50)]
    public string? AdrDomKv { get; set; }

    [Column("trudRabota")]
    [StringLength(300)]
    public string? TrudRabota { get; set; }

    [Column("trudStajObGod")]
    public byte? TrudStajObGod { get; set; }

    [Column("trudStajObMes")]
    public byte? TrudStajObMes { get; set; }

    [Column("trudStajSpecGod")]
    public byte? TrudStajSpecGod { get; set; }

    [Column("trudStajSpecMes")]
    public byte? TrudStajSpecMes { get; set; }

    [Column("obrIs5Balln")]
    public bool ObrIs5Balln { get; set; }

    [Column("obrSrBallOcText")]
    [StringLength(300)]
    public string? ObrSrBallOcText { get; set; }

    [Column("obrSrBall")]
    public short? ObrSrBall { get; set; }

    [Column("lgoti")]
    [StringLength(150)]
    public string? Lgoti { get; set; }

    [Column("isKonk")]
    public bool? IsKonk { get; set; }

    [Column("isBezEkz")]
    public bool? IsBezEkz { get; set; }

    [Column("bezEkzId")]
    public byte? BezEkzId { get; set; }

    [Column("isVneKonk")]
    public bool? IsVneKonk { get; set; }

    [Column("vneKonkId")]
    public byte? VneKonkId { get; set; }

    [Column("summaBallov")]
    public short? SummaBallov { get; set; }

    [Column("vtVsh")]
    public bool VtVsh { get; set; }

    [Column("predFIO")]
    [StringLength(300)]
    public string? PredFio { get; set; }

    [Column("predAddress")]
    [StringLength(500)]
    public string? PredAddress { get; set; }

    [Column("predPasTypeId")]
    public byte PredPasTypeId { get; set; }

    [Column("predPasInoe")]
    [StringLength(255)]
    public string? PredPasInoe { get; set; }

    [Column("predPasLichNomer")]
    [StringLength(15)]
    public string? PredPasLichNomer { get; set; }

    [Column("predPasSer")]
    [StringLength(10)]
    public string? PredPasSer { get; set; }

    [Column("predPasNom")]
    [StringLength(20)]
    public string? PredPasNom { get; set; }

    [Column("predPasData", TypeName = "smalldatetime")]
    public DateTime? PredPasData { get; set; }

    [Column("predPasKemVidan")]
    [StringLength(255)]
    public string? PredPasKemVidan { get; set; }

    [Column("dateOfAddDocuments")]
    public DateOnly? DateOfAddDocuments { get; set; }

    [Column("accept_SpecialityId")]
    public short? AcceptSpecialityId { get; set; }

    [Column("accept_SpecializationId")]
    public short? AcceptSpecializationId { get; set; }

    [Column("photoId")]
    public int? PhotoId { get; set; }

    [Column("ssuzSpecId")]
    public short? SsuzSpecId { get; set; }

    [Column("isExamInRussian")]
    public bool IsExamInRussian { get; set; }

    [Column("createdBy")]
    public Guid? CreatedBy { get; set; }

    [Column("updatedBy")]
    public Guid? UpdatedBy { get; set; }

    [Column("placeId")]
    public byte? PlaceId { get; set; }

    [Column("abtCodeExport")]
    [StringLength(30)]
    public string? AbtCodeExport { get; set; }

    [Column("contractCode")]
    [StringLength(30)]
    public string? ContractCode { get; set; }

    [Column("isUkraine")]
    public bool IsUkraine { get; set; }

    [Column("isSportsman")]
    public bool IsSportsman { get; set; }

    [Column("isInvalid")]
    public bool IsInvalid { get; set; }

    [Column("nomerPrikaza")]
    [StringLength(10)]
    public string? NomerPrikaza { get; set; }

    [Column("dataPrikaza")]
    public DateOnly? DataPrikaza { get; set; }

    [Column("imLatin")]
    [StringLength(255)]
    public string? ImLatin { get; set; }

    [Column("famLatin")]
    [StringLength(255)]
    public string? FamLatin { get; set; }

    [Column("pasValidity", TypeName = "smalldatetime")]
    public DateTime? PasValidity { get; set; }

    [Column("famBLR")]
    [StringLength(255)]
    public string? FamBlr { get; set; }

    [Column("imBLR")]
    [StringLength(255)]
    public string? ImBlr { get; set; }

    [Column("otchBLR")]
    [StringLength(255)]
    public string? OtchBlr { get; set; }

    [Column("birthPlaceCity")]
    [StringLength(255)]
    public string? BirthPlaceCity { get; set; }

    [Column("birthPlaceState")]
    [StringLength(255)]
    public string? BirthPlaceState { get; set; }

    [Column("birthPlaceCountry")]
    [StringLength(255)]
    public string? BirthPlaceCountry { get; set; }

    [Column("birthPlaceCountryCode")]
    [StringLength(255)]
    public string? BirthPlaceCountryCode { get; set; }

    [Column("pasPhoto", TypeName = "text")]
    public string? PasPhoto { get; set; }

    [Column("birthPlaceNasPunktTip")]
    [StringLength(50)]
    public string? BirthPlaceNasPunktTip { get; set; }

    [Column("spetialization_class_id")]
    public byte SpetializationClassId { get; set; }

    [StringLength(255)]
    public string? DopInfo { get; set; }

    [InverseProperty("Abitur")]
    public virtual ICollection<AbiturOcenki> AbiturOcenkis { get; set; } = new List<AbiturOcenki>();

    [InverseProperty("Abitur")]
    public virtual ICollection<AbiturPolupr> AbiturPoluprs { get; set; } = new List<AbiturPolupr>();

    [InverseProperty("Abitur")]
    public virtual ICollection<AbiturRegStepChangeLog> AbiturRegStepChangeLogs { get; set; } = new List<AbiturRegStepChangeLog>();

    [InverseProperty("Abitur")]
    public virtual ICollection<AbiturZayvl> AbiturZayvls { get; set; } = new List<AbiturZayvl>();

    [ForeignKey("AcceptSpecialityId")]
    [InverseProperty("Abiturs")]
    public virtual VuzSpec? AcceptSpeciality { get; set; }

    [InverseProperty("Abitur")]
    public virtual ICollection<Accept> Accepts { get; set; } = new List<Accept>();

    [ForeignKey("BezEkzId")]
    [InverseProperty("Abiturs")]
    public virtual LgotiBezEkz? BezEkz { get; set; }

    [InverseProperty("Abitur")]
    public virtual ICollection<ConsentForPdp> ConsentForPdps { get; set; } = new List<ConsentForPdp>();

    [ForeignKey("CreatedBy")]
    [InverseProperty("Abiturs")]
    public virtual ApplicationUser? CreatedByNavigation { get; set; }

    [ForeignKey("ObrDokTypeId")]
    [InverseProperty("Abiturs")]
    public virtual ObrDokType ObrDokType { get; set; } = null!;

    [ForeignKey("ObrUchId")]
    [InverseProperty("Abiturs")]
    public virtual ObrUchregd ObrUch { get; set; } = null!;

    [ForeignKey("ObrUrovId")]
    [InverseProperty("Abiturs")]
    public virtual ObrUroven ObrUrov { get; set; } = null!;

    [ForeignKey("PasTypeId")]
    [InverseProperty("AbiturPasTypes")]
    public virtual PassportType PasType { get; set; } = null!;

    [ForeignKey("PlaceId")]
    [InverseProperty("Abiturs")]
    public virtual Place? Place { get; set; }

    [ForeignKey("PredPasTypeId")]
    [InverseProperty("AbiturPredPasTypes")]
    public virtual PassportType PredPasType { get; set; } = null!;

    [ForeignKey("SpetializationClassId")]
    [InverseProperty("Abiturs")]
    public virtual SpetializationGrade SpetializationClass { get; set; } = null!;

    [ForeignKey("VneKonkId")]
    [InverseProperty("Abiturs")]
    public virtual LgotiVneKonk? VneKonk { get; set; }
}
