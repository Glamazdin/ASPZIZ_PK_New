using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASPZIZ_PK_New.Features;

internal static class MapsterConfiguration
{
    public static void Configure()
    {
        TypeAdapterConfig<ApplicationUser, UserListModel>
            .NewConfig()
            .Map(dest => dest.Place, src => src.Place.PlaceName);

        TypeAdapterConfig<OkskSpec, OKSKModel>
            .NewConfig()
            .Map(dest => dest.CountUsed, src => src.VuzSpecs.Count)
            .Map(dest=>dest.Name, src=>src.SpecName)
            .Map(dest => dest.Id, src => src.SpecId)
            .Map(dest => dest.Code, src => src.SpecCode)
            .Map(dest => dest.Abbr, src => src.SpecAbbr)
            .Map(dest => dest.Kvalif, src => src.SpecKvalif);

        TypeAdapterConfig<VuzSpec, SpecialityListModel>
            .NewConfig()
            .Map(dest => dest.VuzSpecId, src => src.VuzSpecId)
            .Map(dest => dest.FacltId, src => src.FacltId)
            .Map(dest => dest.FacultyName, src => src.Faclt.FacltNameRu)
            .Map(dest => dest.SpecialityName, src => src.Spec.SpecName)
            .Map(dest => dest.OplataB, src => src.OplataB)
            .Map(dest => dest.ObrVidId, src => src.ObrVidId)
            .Map(dest => dest.ObrVidName, src => src.ObrVid.ObrVidName)
            .Map(dest => dest.VuzSrokId, src => src.VuzSrokId)
            .Map(dest => dest.Srok, src => src.VuzSrok.SrokName)
            .Map(dest => dest.SpecGroupId, src => src.SpecGroupId)
            .Map(dest => dest.GroupName, src => src.SpecGroup.GroupName)
            .Map(dest=>dest.ObrFormaId, srs=>srs.ObrVid.ObrForma.ObrFormaId)
            .Map(dest=>dest.ObrFormaName, src=>src.ObrVid.ObrForma.ObrFormaName);
    }
}
