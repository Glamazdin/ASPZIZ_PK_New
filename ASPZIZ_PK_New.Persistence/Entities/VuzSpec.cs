using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPZIZ_PK_New.Persistence.Entities;

[Table("Vuz_Spec")]
public partial class VuzSpec
{
    [Key]
    [Column("vuzSpecId")]
    public short VuzSpecId { get; set; }

    [Column("vuzId")]
    public byte VuzId { get; set; }

    [Column("facltId")]
    public short FacltId { get; set; }

    [Column("specId")]
    public short SpecId { get; set; }

    [Column("oplataB")]
    public bool OplataB { get; set; }

    [Column("obrVidId")]
    public byte ObrVidId { get; set; }

    [Column("vuzSrokId")]
    public byte VuzSrokId { get; set; }

    [Column("celevB")]
    public bool CelevB { get; set; }

    [Column("kolvoMest")]
    public short KolvoMest { get; set; }

    [Column("countOfPlaces_OutOfCompetition_Orphan")]
    public short? CountOfPlacesOutOfCompetitionOrphan { get; set; }

    [Column("countOfPlaces_OutOfCompetition_Guard")]
    public short? CountOfPlacesOutOfCompetitionGuard { get; set; }

    [Column("specGroupId")]
    public byte SpecGroupId { get; set; }

    [Column("specCode")]
    [StringLength(10)]
    public string? SpecCode { get; set; }

    [Column("nomerPrikaza")]
    [StringLength(10)]
    public string? NomerPrikaza { get; set; }

    [Column("dataPrikaza")]
    public DateOnly? DataPrikaza { get; set; }

    [Column("sobrMesto")]
    [StringLength(50)]
    public string? SobrMesto { get; set; }

    [Column("sobrData")]
    [StringLength(50)]
    public string? SobrData { get; set; }

    [Column("specLotusAbbr")]
    [StringLength(32)]
    public string? SpecLotusAbbr { get; set; }

    [Column("specLotusId")]
    public byte? SpecLotusId { get; set; }

    [Column("statSpecGroupId")]
    public int StatSpecGroupId { get; set; }

    [StringLength(32)]
    public string? ColorForStatistics { get; set; }

    [Column("militaryB")]
    public bool MilitaryB { get; set; }

    [Column("customerId")]
    public short? CustomerId { get; set; }

    public short OutOfCompetitionAll { get; set; }

    [InverseProperty("VuzSpec")]
    public virtual ICollection<AbiturZayvl> AbiturZayvls { get; set; } = new List<AbiturZayvl>();

    [InverseProperty("AcceptSpeciality")]
    public virtual ICollection<Abitur> Abiturs { get; set; } = new List<Abitur>();

    [ForeignKey("CustomerId")]
    [InverseProperty("VuzSpecs")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("FacltId")]
    [InverseProperty("VuzSpecs")]
    public virtual VuzFaclt Faclt { get; set; } = null!;

    [ForeignKey("ObrVidId")]
    [InverseProperty("VuzSpecs")]
    public virtual ObrVid ObrVid { get; set; } = null!;

    [InverseProperty("Speciality")]
    public virtual ICollection<PlaceAfterAccept> PlaceAfterAccepts { get; set; } = new List<PlaceAfterAccept>();

    [ForeignKey("SpecId")]
    [InverseProperty("VuzSpecs")]
    public virtual OkskSpec Spec { get; set; } = null!;

    [ForeignKey("SpecGroupId")]
    [InverseProperty("VuzSpecs")]
    public virtual GroupOfSpeciality SpecGroup { get; set; } = null!;

    [ForeignKey("StatSpecGroupId")]
    [InverseProperty("VuzSpecs")]
    public virtual StatSpecGroup StatSpecGroup { get; set; } = null!;

    [ForeignKey("VuzId")]
    [InverseProperty("VuzSpecs")]
    public virtual Vuz Vuz { get; set; } = null!;

    [InverseProperty("VuzSpec")]
    public virtual ICollection<VuzSpecialization> VuzSpecializations { get; set; } = new List<VuzSpecialization>();

    [ForeignKey("VuzSrokId")]
    [InverseProperty("VuzSpecs")]
    public virtual VuzSrok VuzSrok { get; set; } = null!;
}
