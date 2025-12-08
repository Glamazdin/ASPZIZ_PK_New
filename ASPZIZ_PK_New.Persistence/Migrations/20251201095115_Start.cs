using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPZIZ_PK_New.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ConsentPDP",
            //    columns: table => new
            //    {
            //        ConsentId = table.Column<int>(type: "int", nullable: false),
            //        name = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ConsentPDP", x => x.ConsentId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CT_Uchastniki",
            //    columns: table => new
            //    {
            //        ctUchId = table.Column<int>(type: "int", nullable: false),
            //        fam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        im = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        otch = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        pasSer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        pasNom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CT_Uchastniki", x => x.ctUchId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Customers",
            //    columns: table => new
            //    {
            //        customerId = table.Column<short>(type: "smallint", nullable: false),
            //        customerFullName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        customerShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        UNP = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Customers", x => x.customerId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "EntrantsOfInnerExams",
            //    columns: table => new
            //    {
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Surname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        Patronymic = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        PassportSerial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        PassportNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        pasInoe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ExamLanguageId = table.Column<bool>(type: "bit", nullable: false),
            //        EducationForm_Id = table.Column<byte>(type: "tinyint", nullable: false),
            //        EducationForm_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        EducationTerm_Id = table.Column<byte>(type: "tinyint", nullable: false),
            //        EducationTerm_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Faculty_Id = table.Column<short>(type: "smallint", nullable: false),
            //        Faculty_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        SpecialityId = table.Column<short>(type: "smallint", nullable: false),
            //        Speciality_OKSK_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        Speciality_OKSK_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        ExamLanguageName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
            //        EkzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        ExamName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ExamMark = table.Column<byte>(type: "tinyint", nullable: true),
            //        ExamTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        ExamTypeName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ExamType",
            //    columns: table => new
            //    {
            //        examTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        examTypeName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
            //        examTypeShort = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ExamType", x => x.examTypeId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Gragdanstvo",
            //    columns: table => new
            //    {
            //        gragdId = table.Column<byte>(type: "tinyint", nullable: false),
            //        gragdName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Gragdanstvo", x => x.gragdId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GroupOfSpecialities",
            //    columns: table => new
            //    {
            //        groupId = table.Column<byte>(type: "tinyint", nullable: false),
            //        groupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        acceptStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1)
            //            .Annotation("Relational:DefaultConstraintName", "DF_SpecGroup_acceptStatus"),
            //        acceptStatus_DateOfUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        acceptReportName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        acceptReportStream = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        acceptReport_DateOfUpdate = table.Column<DateOnly>(type: "date", nullable: true),
            //        isLocked = table.Column<bool>(type: "bit", nullable: false),
            //        ekzGroupId_1 = table.Column<byte>(type: "tinyint", nullable: true),
            //        ekzGroupId_2 = table.Column<byte>(type: "tinyint", nullable: true),
            //        maxApplicationOnSpec = table.Column<byte>(type: "tinyint", nullable: true),
            //        acceptAlgorithmCode = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SpecGroup", x => x.groupId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GroupsOfSpecialities_Relationships",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        groupParentId = table.Column<byte>(type: "tinyint", nullable: false),
            //        groupChildId = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GroupsOfSpecialities_Rel", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Lgoti_BezEkz",
            //    columns: table => new
            //    {
            //        bezEkzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        beName_Short = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        beName_Full = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Lgoti_BezEkz", x => x.bezEkzId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Lgoti_VneKonk",
            //    columns: table => new
            //    {
            //        vkId = table.Column<byte>(type: "tinyint", nullable: false),
            //        vkName_Short = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        vkName_Full = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Lgoti_VneKonkursa", x => x.vkId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Lgoty_Polupr",
            //    columns: table => new
            //    {
            //        ppId = table.Column<byte>(type: "tinyint", nullable: false),
            //        ppName_Short = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        ppName_Full = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false),
            //        ppPrioritet = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Lgoty_Polupr", x => x.ppId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Obr_Froma",
            //    columns: table => new
            //    {
            //        obrFormaId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrFormaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Obr_Froma", x => x.obrFormaId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Obr_SrBal5_10",
            //    columns: table => new
            //    {
            //        srBal_id = table.Column<byte>(type: "tinyint", nullable: false),
            //        oc5 = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
            //        oc10 = table.Column<decimal>(type: "decimal(3,1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Obr_SrBal5_10", x => x.srBal_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Obr_Uroven",
            //    columns: table => new
            //    {
            //        obrUrovId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrUrovName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ObrUroven", x => x.obrUrovId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OKSK_Spec",
            //    columns: table => new
            //    {
            //        specId = table.Column<short>(type: "smallint", nullable: false),
            //        specName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        specCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        specKvalif = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        specAbbr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        specLotusCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OKSK_Spec", x => x.specId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OKSK_Specialization",
            //    columns: table => new
            //    {
            //        specializationId = table.Column<short>(type: "smallint", nullable: false),
            //        specializationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        specializationAbbr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        specializationCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        specializationLetter = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OKSK_Specialization", x => x.specializationId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PassportType",
            //    columns: table => new
            //    {
            //        pasTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        pasName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Doc", x => x.pasTypeId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Place",
            //    columns: table => new
            //    {
            //        placeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        placeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        placeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        placeCodeForSheetOfRegistration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Place", x => x.placeId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Spetialization_grade",
            //    columns: table => new
            //    {
            //        ProfileClassId = table.Column<byte>(type: "tinyint", nullable: false),
            //        ProfileClassName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Spetialization_grade", x => x.ProfileClassId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SSUZ_Spec",
            //    columns: table => new
            //    {
            //        specId = table.Column<short>(type: "smallint", nullable: false),
            //        specName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SSUZ_Spec", x => x.specId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StatSpecGroup",
            //    columns: table => new
            //    {
            //        statGroupId = table.Column<int>(type: "int", nullable: false),
            //        statGroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        SortOrder = table.Column<int>(type: "int", nullable: true),
            //        siteIsLocked = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
            //        siteOrderUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        siteStatGroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        siteStatGroupTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        siteStatPageName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StatSpecGroup", x => x.statGroupId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tables_queues",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tables_queues", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tables_states",
            //    columns: table => new
            //    {
            //        id = table.Column<byte>(type: "tinyint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        state = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tables_states_1", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz",
            //    columns: table => new
            //    {
            //        vuzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        vuzNameRU = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        vuzAbbrRU = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        vuzNameBY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        vuAbbrBY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz", x => x.vuzId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz_Faclt",
            //    columns: table => new
            //    {
            //        facltId = table.Column<short>(type: "smallint", nullable: false),
            //        vuzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        facltNameRU = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        facltAbbrRU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        facltLotusCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        facltLotusAbbr = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        ColorForStatistics = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz_Faclt", x => x.facltId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz_Srok",
            //    columns: table => new
            //    {
            //        vuzSrokId = table.Column<byte>(type: "tinyint", nullable: false),
            //        srokName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz_Srok", x => x.vuzSrokId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserPasskeys",
            //    columns: table => new
            //    {
            //        CredentialId = table.Column<byte[]>(type: "varbinary(1024)", maxLength: 1024, nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserPasskeys", x => x.CredentialId);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserPasskeys_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Permission_User",
            //    columns: table => new
            //    {
            //        permUserId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        permissionId = table.Column<byte>(type: "tinyint", nullable: false),
            //        userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        partId = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Permission_User", x => x.permUserId);
            //        table.ForeignKey(
            //            name: "FK_PermissionUser_AspNetUsers",
            //            column: x => x.userId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Exam",
            //    columns: table => new
            //    {
            //        ekzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        ekzName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        ekzGroupId = table.Column<byte>(type: "tinyint", nullable: true),
            //        examTypeId = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CT_Discipl", x => x.ekzId);
            //        table.ForeignKey(
            //            name: "FK_Ekzamen_ExamType",
            //            column: x => x.examTypeId,
            //            principalTable: "ExamType",
            //            principalColumn: "examTypeId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Register",
            //    columns: table => new
            //    {
            //        registerId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        entrantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        createdByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        groupId = table.Column<byte>(type: "tinyint", nullable: false),
            //        entrantCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        dateOfAccept = table.Column<DateTime>(type: "datetime", nullable: false),
            //        entrantInitials = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
            //        nationality = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        certificates = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        privileges = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
            //        adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
            //        isTarget = table.Column<bool>(type: "bit", nullable: false),
            //        isEnrolled = table.Column<bool>(type: "bit", nullable: false),
            //        isReturned = table.Column<bool>(type: "bit", nullable: false),
            //        isSecondDegree = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("primaryRegisterIdKey", x => x.registerId);
            //        table.ForeignKey(
            //            name: "FK_Register_AspNetUsers_CreatedBy",
            //            column: x => x.createdByUserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "foreignRegisterToGroupOfSpecialities",
            //            column: x => x.groupId,
            //            principalTable: "GroupOfSpecialities",
            //            principalColumn: "groupId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Obr_Vid",
            //    columns: table => new
            //    {
            //        obrVidId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrFormaId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrVidName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        obrLotusCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Obr_Vid", x => x.obrVidId);
            //        table.ForeignKey(
            //            name: "FK_Obr_Vid_Obr_Froma",
            //            column: x => x.obrFormaId,
            //            principalTable: "Obr_Froma",
            //            principalColumn: "obrFormaId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Obr_DokType",
            //    columns: table => new
            //    {
            //        obrDokTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrUrovId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrDokName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PK_ObrazovanieDokumenti", x => x.obrDokTypeId);
            //        table.ForeignKey(
            //            name: "FK_Obr_Dok_Obr_Uroven",
            //            column: x => x.obrUrovId,
            //            principalTable: "Obr_Uroven",
            //            principalColumn: "obrUrovId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Obr_Uchregd",
            //    columns: table => new
            //    {
            //        obrUchId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrUrovId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrUchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        obrLotusAbbr = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Obrazovanie_Uchregdeniya", x => x.obrUchId);
            //        table.ForeignKey(
            //            name: "FK_Obr_Uchregd_Obr_Uroven",
            //            column: x => x.obrUrovId,
            //            principalTable: "Obr_Uroven",
            //            principalColumn: "obrUrovId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OKSK_Spec_Specialization",
            //    columns: table => new
            //    {
            //        Id = table.Column<short>(type: "smallint", nullable: false),
            //        specializationId = table.Column<short>(type: "smallint", nullable: false),
            //        specId = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OKSK_Spec_Specialization", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OKSK_Spec_Specialization_OKSK_Spec",
            //            column: x => x.specId,
            //            principalTable: "OKSK_Spec",
            //            principalColumn: "specId");
            //        table.ForeignKey(
            //            name: "FK_OKSK_Spec_Specialization_OKSK_Specialization",
            //            column: x => x.specializationId,
            //            principalTable: "OKSK_Specialization",
            //            principalColumn: "specializationId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Place_User",
            //    columns: table => new
            //    {
            //        userPlaceId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        placeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Place_User", x => x.userPlaceId);
            //        table.ForeignKey(
            //            name: "FK_PlaceUser_AspNetUsers",
            //            column: x => x.userId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Place_User_Place_User",
            //            column: x => x.placeId,
            //            principalTable: "Place",
            //            principalColumn: "placeId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz_SSUZ_Spec",
            //    columns: table => new
            //    {
            //        id = table.Column<short>(type: "smallint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        vuzSpecId = table.Column<short>(type: "smallint", nullable: false),
            //        ssuzSpecId = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz_SSUZ_Spec", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Vuz_SSUZ_Spec_SSUZ_Spec",
            //            column: x => x.ssuzSpecId,
            //            principalTable: "SSUZ_Spec",
            //            principalColumn: "specId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tables_abiturs",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        queueId = table.Column<int>(type: "int", nullable: false),
            //        abtName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        timeAdded = table.Column<DateTime>(type: "datetime", nullable: false),
            //        priority = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tables_ques", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Tables_ques_Tables_queues",
            //            column: x => x.queueId,
            //            principalTable: "Tables_queues",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tables",
            //    columns: table => new
            //    {
            //        table_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        duty_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        state = table.Column<byte>(type: "tinyint", nullable: false),
            //        table_num = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tables_1", x => x.table_id);
            //        table.ForeignKey(
            //            name: "FK_Table_AspNetUsers_Duty",
            //            column: x => x.duty_id,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Table_AspNetUsers_TableId",
            //            column: x => x.table_id,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Tables_Tables_states1",
            //            column: x => x.state,
            //            principalTable: "Tables_states",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tables_logs",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        table_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        changer_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        new_state = table.Column<byte>(type: "tinyint", nullable: false),
            //        time_changed = table.Column<DateTime>(type: "datetime", nullable: false),
            //        message = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tables_logs", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_TablesLog_AspNetUsers_Changer",
            //            column: x => x.changer_id,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_TablesLog_AspNetUsers_TableId",
            //            column: x => x.table_id,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Tables_logs_Tables_states",
            //            column: x => x.new_state,
            //            principalTable: "Tables_states",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CT_Certificaty",
            //    columns: table => new
            //    {
            //        ctId = table.Column<int>(type: "int", nullable: false),
            //        ctUchId = table.Column<int>(type: "int", nullable: false),
            //        predmId = table.Column<byte>(type: "tinyint", nullable: false),
            //        ball = table.Column<byte>(type: "tinyint", nullable: false),
            //        ctNomer = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CT_Certificaty", x => x.ctId);
            //        table.ForeignKey(
            //            name: "FK_CT_Certificaty_CT_Uchastniki",
            //            column: x => x.ctUchId,
            //            principalTable: "CT_Uchastniki",
            //            principalColumn: "ctUchId");
            //        table.ForeignKey(
            //            name: "FK_CT_Certificaty_Ekzamen",
            //            column: x => x.predmId,
            //            principalTable: "Exam",
            //            principalColumn: "ekzId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ExamType_100_ballov",
            //    columns: table => new
            //    {
            //        id = table.Column<byte>(type: "tinyint", nullable: false),
            //        ekzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        Opisanie = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ekzamen_100_ballov", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Ekzamen_100_ballov_Ekzamen",
            //            column: x => x.ekzId,
            //            principalTable: "Exam",
            //            principalColumn: "ekzId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz_Spec_Ekz",
            //    columns: table => new
            //    {
            //        vuzSpecEkzId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        vuzSpecId = table.Column<short>(type: "smallint", nullable: false),
            //        ekzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        prioritet = table.Column<byte>(type: "tinyint", nullable: false),
            //        minBall = table.Column<byte>(type: "tinyint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz_Spec_Ekz", x => x.vuzSpecEkzId);
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_Ekz_Ekzamen",
            //            column: x => x.ekzId,
            //            principalTable: "Exam",
            //            principalColumn: "ekzId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz_Spec",
            //    columns: table => new
            //    {
            //        vuzSpecId = table.Column<short>(type: "smallint", nullable: false),
            //        vuzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        facltId = table.Column<short>(type: "smallint", nullable: false),
            //        specId = table.Column<short>(type: "smallint", nullable: false),
            //        oplataB = table.Column<bool>(type: "bit", nullable: false),
            //        obrVidId = table.Column<byte>(type: "tinyint", nullable: false),
            //        vuzSrokId = table.Column<byte>(type: "tinyint", nullable: false),
            //        celevB = table.Column<bool>(type: "bit", nullable: false),
            //        kolvoMest = table.Column<short>(type: "smallint", nullable: false),
            //        countOfPlaces_OutOfCompetition_Orphan = table.Column<short>(type: "smallint", nullable: true),
            //        countOfPlaces_OutOfCompetition_Guard = table.Column<short>(type: "smallint", nullable: true),
            //        specGroupId = table.Column<byte>(type: "tinyint", nullable: false),
            //        specCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        nomerPrikaza = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        dataPrikaza = table.Column<DateOnly>(type: "date", nullable: true),
            //        sobrMesto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        sobrData = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        specLotusAbbr = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        specLotusId = table.Column<byte>(type: "tinyint", nullable: true),
            //        statSpecGroupId = table.Column<int>(type: "int", nullable: false),
            //        ColorForStatistics = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        militaryB = table.Column<bool>(type: "bit", nullable: false),
            //        customerId = table.Column<short>(type: "smallint", nullable: true),
            //        OutOfCompetitionAll = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz_Spec", x => x.vuzSpecId);
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_Customers",
            //            column: x => x.customerId,
            //            principalTable: "Customers",
            //            principalColumn: "customerId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_OKSK_Spec",
            //            column: x => x.specId,
            //            principalTable: "OKSK_Spec",
            //            principalColumn: "specId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_Obr_Vid",
            //            column: x => x.obrVidId,
            //            principalTable: "Obr_Vid",
            //            principalColumn: "obrVidId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_SpecGroup",
            //            column: x => x.specGroupId,
            //            principalTable: "GroupOfSpecialities",
            //            principalColumn: "groupId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_StatSpecGroup",
            //            column: x => x.statSpecGroupId,
            //            principalTable: "StatSpecGroup",
            //            principalColumn: "statGroupId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_Vuz",
            //            column: x => x.vuzId,
            //            principalTable: "Vuz",
            //            principalColumn: "vuzId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_Vuz_Faclt",
            //            column: x => x.facltId,
            //            principalTable: "Vuz_Faclt",
            //            principalColumn: "facltId");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Spec_Vuz_Srok",
            //            column: x => x.vuzSrokId,
            //            principalTable: "Vuz_Srok",
            //            principalColumn: "vuzSrokId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tables_tableToQueue",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        table_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        queue_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Tables_t__3213E83FA4DD4C81", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Tables_tableToQueue_Queue_Id",
            //            column: x => x.queue_id,
            //            principalTable: "Tables_queues",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "FK_Tables_tableToQueue_Table_Id",
            //            column: x => x.table_id,
            //            principalTable: "Tables",
            //            principalColumn: "table_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Abitur",
            //    columns: table => new
            //    {
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())")
            //            .Annotation("Relational:DefaultConstraintName", "DF_Abitur_abiturId"),
            //        regStep = table.Column<byte>(type: "tinyint", nullable: true),
            //        dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
            //        dateUpdated = table.Column<DateTime>(type: "datetime", nullable: false),
            //        abtCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        fam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        im = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        otch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        dataRogd = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        polB = table.Column<bool>(type: "bit", nullable: true),
            //        pasTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        pasInoe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pasLichNomer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        pasSer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        pasNom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        pasData = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        pasKemVidan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        obrUrovId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrUchId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrDokTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        obrDokNomer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        obrUchrCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        obrDataOkon = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        obrPodgOtdelB = table.Column<bool>(type: "bit", nullable: false),
            //        obrInYaz = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        telKodGoroda = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        telDom = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        telMob = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        semejnoePologB = table.Column<bool>(type: "bit", nullable: true),
            //        obschB = table.Column<bool>(type: "bit", nullable: false),
            //        otecTipRodstva = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        otecFam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        otecIm = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        otecOtch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        otecAddr = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //        otecRabota = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        matTipRodstva = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        matFam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        matIm = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        matOtch = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        matAddr = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //        matRabota = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        adrIndeks = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        adrStrana = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrOblast = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrRajon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrNasPunktTip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrNasPunktName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrUlTip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrUlName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        adrDomNom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrDomKorp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adrDomKv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        trudRabota = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        trudStajObGod = table.Column<byte>(type: "tinyint", nullable: true),
            //        trudStajObMes = table.Column<byte>(type: "tinyint", nullable: true),
            //        trudStajSpecGod = table.Column<byte>(type: "tinyint", nullable: true),
            //        trudStajSpecMes = table.Column<byte>(type: "tinyint", nullable: true),
            //        obrIs5Balln = table.Column<bool>(type: "bit", nullable: false),
            //        obrSrBallOcText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        obrSrBall = table.Column<short>(type: "smallint", nullable: true),
            //        lgoti = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        isKonk = table.Column<bool>(type: "bit", nullable: true),
            //        isBezEkz = table.Column<bool>(type: "bit", nullable: true),
            //        bezEkzId = table.Column<byte>(type: "tinyint", nullable: true),
            //        isVneKonk = table.Column<bool>(type: "bit", nullable: true),
            //        vneKonkId = table.Column<byte>(type: "tinyint", nullable: true),
            //        summaBallov = table.Column<short>(type: "smallint", nullable: true),
            //        vtVsh = table.Column<bool>(type: "bit", nullable: false),
            //        predFIO = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        predAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        predPasTypeId = table.Column<byte>(type: "tinyint", nullable: false),
            //        predPasInoe = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        predPasLichNomer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        predPasSer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        predPasNom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        predPasData = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        predPasKemVidan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        dateOfAddDocuments = table.Column<DateOnly>(type: "date", nullable: true),
            //        accept_SpecialityId = table.Column<short>(type: "smallint", nullable: true),
            //        accept_SpecializationId = table.Column<short>(type: "smallint", nullable: true),
            //        photoId = table.Column<int>(type: "int", nullable: true),
            //        ssuzSpecId = table.Column<short>(type: "smallint", nullable: true),
            //        isExamInRussian = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
            //            .Annotation("Relational:DefaultConstraintName", "DF__Abitur__isExamIn__02133CD2"),
            //        createdBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        updatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        placeId = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0)
            //            .Annotation("Relational:DefaultConstraintName", "DF__Abitur__placeId__2DF1BF10"),
            //        abtCodeExport = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        contractCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        isUkraine = table.Column<bool>(type: "bit", nullable: false),
            //        isSportsman = table.Column<bool>(type: "bit", nullable: false),
            //        isInvalid = table.Column<bool>(type: "bit", nullable: false),
            //        nomerPrikaza = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        dataPrikaza = table.Column<DateOnly>(type: "date", nullable: true),
            //        imLatin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
            //            .Annotation("Relational:DefaultConstraintName", "DF__Abitur__imLatin__37C5420D"),
            //        famLatin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(NULL)")
            //            .Annotation("Relational:DefaultConstraintName", "DF__Abitur__famLatin__38B96646"),
            //        pasValidity = table.Column<DateTime>(type: "smalldatetime", nullable: true, defaultValueSql: "(NULL)")
            //            .Annotation("Relational:DefaultConstraintName", "DF__Abitur__pasValid__39AD8A7F"),
            //        famBLR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        imBLR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        otchBLR = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        birthPlaceCity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        birthPlaceState = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        birthPlaceCountry = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        birthPlaceCountryCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        pasPhoto = table.Column<string>(type: "text", nullable: true),
            //        birthPlaceNasPunktTip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(NULL)")
            //            .Annotation("Relational:DefaultConstraintName", "DF__Abitur__birthPla__3AA1AEB8"),
            //        spetialization_class_id = table.Column<byte>(type: "tinyint", nullable: false),
            //        DopInfo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Abitur_1", x => x.abiturId);
            //        table.ForeignKey(
            //            name: "FK_Abitur_AspNetUsers",
            //            column: x => x.createdBy,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Doc",
            //            column: x => x.pasTypeId,
            //            principalTable: "PassportType",
            //            principalColumn: "pasTypeId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Lgoti_BezEkz",
            //            column: x => x.bezEkzId,
            //            principalTable: "Lgoti_BezEkz",
            //            principalColumn: "bezEkzId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Lgoti_VneKonk",
            //            column: x => x.vneKonkId,
            //            principalTable: "Lgoti_VneKonk",
            //            principalColumn: "vkId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Obr_DokType",
            //            column: x => x.obrDokTypeId,
            //            principalTable: "Obr_DokType",
            //            principalColumn: "obrDokTypeId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Obr_Uchregd",
            //            column: x => x.obrUchId,
            //            principalTable: "Obr_Uchregd",
            //            principalColumn: "obrUchId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Obr_Uroven",
            //            column: x => x.obrUrovId,
            //            principalTable: "Obr_Uroven",
            //            principalColumn: "obrUrovId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_PassportType",
            //            column: x => x.predPasTypeId,
            //            principalTable: "PassportType",
            //            principalColumn: "pasTypeId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Place",
            //            column: x => x.placeId,
            //            principalTable: "Place",
            //            principalColumn: "placeId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Spetialization_grade",
            //            column: x => x.spetialization_class_id,
            //            principalTable: "Spetialization_grade",
            //            principalColumn: "ProfileClassId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Vuz_Spec",
            //            column: x => x.accept_SpecialityId,
            //            principalTable: "Vuz_Spec",
            //            principalColumn: "vuzSpecId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Place_AfterAccept",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        specialityId = table.Column<short>(type: "smallint", nullable: false),
            //        placeId = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Palce_AfterAccept", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Palce_AfterAccept_Place",
            //            column: x => x.placeId,
            //            principalTable: "Place",
            //            principalColumn: "placeId");
            //        table.ForeignKey(
            //            name: "FK_Palce_AfterAccept_Vuz_Spec",
            //            column: x => x.specialityId,
            //            principalTable: "Vuz_Spec",
            //            principalColumn: "vuzSpecId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vuz_Specialization",
            //    columns: table => new
            //    {
            //        vuzSpecializationId = table.Column<short>(type: "smallint", nullable: false),
            //        vuzSpecId = table.Column<short>(type: "smallint", nullable: false),
            //        specSpecializationId = table.Column<short>(type: "smallint", nullable: false),
            //        countOfPlaces = table.Column<short>(type: "smallint", nullable: false),
            //        countOfPlaces_Orphan = table.Column<short>(type: "smallint", nullable: false),
            //        countOfPlaces_Guard = table.Column<short>(type: "smallint", nullable: false),
            //        codeLetter = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        bseuId = table.Column<byte>(type: "tinyint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vuz_Specialization", x => x.vuzSpecializationId);
            //        table.ForeignKey(
            //            name: "FK_Vuz_Specialization_OKSK_Spec_Specialization",
            //            column: x => x.specSpecializationId,
            //            principalTable: "OKSK_Spec_Specialization",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vuz_Specialization_Vuz_Spec",
            //            column: x => x.vuzSpecId,
            //            principalTable: "Vuz_Spec",
            //            principalColumn: "vuzSpecId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Abitur_Ocenki",
            //    columns: table => new
            //    {
            //        ocId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EkzId = table.Column<byte>(type: "tinyint", nullable: false),
            //        EkzOc = table.Column<byte>(type: "tinyint", nullable: true),
            //        ObrOc = table.Column<byte>(type: "tinyint", nullable: true),
            //        DokNom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        IsSel = table.Column<bool>(type: "bit", nullable: true),
            //        Is100BallovId = table.Column<byte>(type: "tinyint", nullable: true),
            //        examTypeId = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Abitur_Ocenki", x => x.ocId);
            //        table.ForeignKey(
            //            name: "FK_Abitur_Ocenki_Abitur",
            //            column: x => x.abiturId,
            //            principalTable: "Abitur",
            //            principalColumn: "abiturId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Ocenki_Ekzamen",
            //            column: x => x.EkzId,
            //            principalTable: "Exam",
            //            principalColumn: "ekzId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Ocenki_ExamType",
            //            column: x => x.examTypeId,
            //            principalTable: "ExamType",
            //            principalColumn: "examTypeId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Abitur_Polupr",
            //    columns: table => new
            //    {
            //        abtPoluprId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        poluprId = table.Column<byte>(type: "tinyint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Abitur_Polupr", x => x.abtPoluprId);
            //        table.ForeignKey(
            //            name: "FK_Abitur_Polupr_Abitur",
            //            column: x => x.abiturId,
            //            principalTable: "Abitur",
            //            principalColumn: "abiturId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Polupr_Lgoty_Polupr",
            //            column: x => x.poluprId,
            //            principalTable: "Lgoty_Polupr",
            //            principalColumn: "ppId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Abitur_RegStep_ChangeLog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        previousRegStep = table.Column<byte>(type: "tinyint", nullable: true),
            //        currentRegStep = table.Column<byte>(type: "tinyint", nullable: true),
            //        userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        datetimeStamp = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Abitur_RegStep_ChangeLog", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_AbiturRegStepChangeLog_AspNetUsers",
            //            column: x => x.userId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Abitur_RegStep_ChangeLog_Abitur",
            //            column: x => x.abiturId,
            //            principalTable: "Abitur",
            //            principalColumn: "abiturId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Abitur_Zayvl",
            //    columns: table => new
            //    {
            //        zayvlId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        vuzSpecId = table.Column<short>(type: "smallint", nullable: false),
            //        prior = table.Column<byte>(type: "tinyint", nullable: false),
            //        applicationNumber = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1)
            //            .Annotation("Relational:DefaultConstraintName", "DF_Abitur_Zayvl_applicationNumber"),
            //        hash = table.Column<int>(type: "int", nullable: true),
            //        date = table.Column<DateTime>(type: "smalldatetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Zayvl", x => x.zayvlId);
            //        table.ForeignKey(
            //            name: "FK_Abitur_Zayvl_Abitur",
            //            column: x => x.abiturId,
            //            principalTable: "Abitur",
            //            principalColumn: "abiturId");
            //        table.ForeignKey(
            //            name: "FK_Abitur_Zayvl_Vuz_Spec",
            //            column: x => x.vuzSpecId,
            //            principalTable: "Vuz_Spec",
            //            principalColumn: "vuzSpecId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Accept",
            //    columns: table => new
            //    {
            //        recordId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        isPreview = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
            //            .Annotation("Relational:DefaultConstraintName", "DF_Accept_isPreview"),
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        groupId = table.Column<byte>(type: "tinyint", nullable: false),
            //        acceptInGroup_StepId = table.Column<byte>(type: "tinyint", nullable: true),
            //        acceptInGroup_UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        acceptInGroup_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        acceptInGroup_Position = table.Column<int>(type: "int", nullable: true),
            //        acceptInGroup_Result = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
            //            .Annotation("Relational:DefaultConstraintName", "DF_Accept_acceptInGroup_Result"),
            //        acceptInSpeciality_StepId = table.Column<byte>(type: "tinyint", nullable: true),
            //        acceptInSpeciality_UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        acceptInSpeciality_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        acceptInSpeciality_Position = table.Column<int>(type: "int", nullable: true),
            //        acceptInSpeciality_SpecialityId = table.Column<short>(type: "smallint", nullable: false),
            //        acceptInSpeciality_Result = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
            //            .Annotation("Relational:DefaultConstraintName", "DF_Accept_acceptInSpeciality_Result"),
            //        acceptInSpecialization_UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        acceptInSpecialization_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        acceptInSpecialization_SpecializationId = table.Column<short>(type: "smallint", nullable: false),
            //        acceptInSpecialization_Submit = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Accept", x => x.recordId);
            //        table.ForeignKey(
            //            name: "FK_Accept_Abitur",
            //            column: x => x.abiturId,
            //            principalTable: "Abitur",
            //            principalColumn: "abiturId");
            //        table.ForeignKey(
            //            name: "FK_Accept_AspNetUsers_GroupUser",
            //            column: x => x.acceptInGroup_UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Accept_AspNetUsers_SpecialityUser",
            //            column: x => x.acceptInSpeciality_UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Accept_SpecGroup",
            //            column: x => x.groupId,
            //            principalTable: "GroupOfSpecialities",
            //            principalColumn: "groupId");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ConsentForPDP",
            //    columns: table => new
            //    {
            //        consentAbiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())")
            //            .Annotation("Relational:DefaultConstraintName", "DF_ConsentForPDP_consentAbiturId"),
            //        abiturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ConsentId = table.Column<int>(type: "int", nullable: false),
            //        result = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ConsentForPDP", x => x.consentAbiturId);
            //        table.ForeignKey(
            //            name: "FK_ConsentForPDP_ConsentId",
            //            column: x => x.ConsentId,
            //            principalTable: "ConsentPDP",
            //            principalColumn: "ConsentId");
            //        table.ForeignKey(
            //            name: "FK_ConsentForPDP_abiturId",
            //            column: x => x.abiturId,
            //            principalTable: "Abitur",
            //            principalColumn: "abiturId");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_accept_SpecialityId",
            //    table: "Abitur",
            //    column: "accept_SpecialityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_bezEkzId",
            //    table: "Abitur",
            //    column: "bezEkzId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_createdBy",
            //    table: "Abitur",
            //    column: "createdBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_obrDokTypeId",
            //    table: "Abitur",
            //    column: "obrDokTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_obrUchId",
            //    table: "Abitur",
            //    column: "obrUchId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_obrUrovId",
            //    table: "Abitur",
            //    column: "obrUrovId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_pasTypeId",
            //    table: "Abitur",
            //    column: "pasTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_placeId",
            //    table: "Abitur",
            //    column: "placeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_predPasTypeId",
            //    table: "Abitur",
            //    column: "predPasTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_spetialization_class_id",
            //    table: "Abitur",
            //    column: "spetialization_class_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_vneKonkId",
            //    table: "Abitur",
            //    column: "vneKonkId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Ocenki_abiturId",
            //    table: "Abitur_Ocenki",
            //    column: "abiturId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Ocenki_EkzId",
            //    table: "Abitur_Ocenki",
            //    column: "EkzId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Ocenki_examTypeId",
            //    table: "Abitur_Ocenki",
            //    column: "examTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Polupr_abiturId",
            //    table: "Abitur_Polupr",
            //    column: "abiturId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Polupr_poluprId",
            //    table: "Abitur_Polupr",
            //    column: "poluprId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_RegStep_ChangeLog_abiturId",
            //    table: "Abitur_RegStep_ChangeLog",
            //    column: "abiturId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_RegStep_ChangeLog_userId",
            //    table: "Abitur_RegStep_ChangeLog",
            //    column: "userId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Zayvl_abiturId",
            //    table: "Abitur_Zayvl",
            //    column: "abiturId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Abitur_Zayvl_vuzSpecId",
            //    table: "Abitur_Zayvl",
            //    column: "vuzSpecId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accept_abiturId",
            //    table: "Accept",
            //    column: "abiturId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accept_acceptInGroup_UserId",
            //    table: "Accept",
            //    column: "acceptInGroup_UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accept_acceptInSpeciality_UserId",
            //    table: "Accept",
            //    column: "acceptInSpeciality_UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accept_groupId",
            //    table: "Accept",
            //    column: "groupId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles",
            //    column: "NormalizedName",
            //    unique: true,
            //    filter: "[NormalizedName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "AspNetUserClaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserPasskeys_UserId",
            //    table: "AspNetUserPasskeys",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedUserName",
            //    unique: true,
            //    filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ConsentForPDP_abiturId",
            //    table: "ConsentForPDP",
            //    column: "abiturId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ConsentForPDP_ConsentId",
            //    table: "ConsentForPDP",
            //    column: "ConsentId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CT_Certificaty_ctUchId",
            //    table: "CT_Certificaty",
            //    column: "ctUchId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CT_Certificaty_predmId",
            //    table: "CT_Certificaty",
            //    column: "predmId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Exam_examTypeId",
            //    table: "Exam",
            //    column: "examTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ExamType_100_ballov_ekzId",
            //    table: "ExamType_100_ballov",
            //    column: "ekzId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Obr_DokType_obrUrovId",
            //    table: "Obr_DokType",
            //    column: "obrUrovId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Obr_Uchregd_obrUrovId",
            //    table: "Obr_Uchregd",
            //    column: "obrUrovId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Obr_Vid_obrFormaId",
            //    table: "Obr_Vid",
            //    column: "obrFormaId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OKSK_Spec_Specialization_specializationId",
            //    table: "OKSK_Spec_Specialization",
            //    column: "specializationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OKSK_Spec_Specialization_specId",
            //    table: "OKSK_Spec_Specialization",
            //    column: "specId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Permission_User_userId",
            //    table: "Permission_User",
            //    column: "userId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Place_AfterAccept_placeId",
            //    table: "Place_AfterAccept",
            //    column: "placeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Place_AfterAccept_specialityId",
            //    table: "Place_AfterAccept",
            //    column: "specialityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Place_User_placeId",
            //    table: "Place_User",
            //    column: "placeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Place_User_userId",
            //    table: "Place_User",
            //    column: "userId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Register_createdByUserId",
            //    table: "Register",
            //    column: "createdByUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Register_groupId",
            //    table: "Register",
            //    column: "groupId");

            //migrationBuilder.CreateIndex(
            //    name: "I_StatName_StatSpecGroup",
            //    table: "StatSpecGroup",
            //    column: "statGroupName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_duty_id",
            //    table: "Tables",
            //    column: "duty_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_state",
            //    table: "Tables",
            //    column: "state");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_abiturs_queueId",
            //    table: "Tables_abiturs",
            //    column: "queueId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_logs_changer_id",
            //    table: "Tables_logs",
            //    column: "changer_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_logs_new_state",
            //    table: "Tables_logs",
            //    column: "new_state");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_logs_table_id",
            //    table: "Tables_logs",
            //    column: "table_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_queues",
            //    table: "Tables_queues",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_states_1",
            //    table: "Tables_states",
            //    column: "state",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_tableToQueue_queue_id",
            //    table: "Tables_tableToQueue",
            //    column: "queue_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tables_tableToQueue_table_id",
            //    table: "Tables_tableToQueue",
            //    column: "table_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_customerId",
            //    table: "Vuz_Spec",
            //    column: "customerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_facltId",
            //    table: "Vuz_Spec",
            //    column: "facltId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_obrVidId",
            //    table: "Vuz_Spec",
            //    column: "obrVidId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_specGroupId",
            //    table: "Vuz_Spec",
            //    column: "specGroupId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_specId",
            //    table: "Vuz_Spec",
            //    column: "specId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_statSpecGroupId",
            //    table: "Vuz_Spec",
            //    column: "statSpecGroupId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_vuzId",
            //    table: "Vuz_Spec",
            //    column: "vuzId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_vuzSrokId",
            //    table: "Vuz_Spec",
            //    column: "vuzSrokId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Spec_Ekz_ekzId",
            //    table: "Vuz_Spec_Ekz",
            //    column: "ekzId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Specialization_specSpecializationId",
            //    table: "Vuz_Specialization",
            //    column: "specSpecializationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_Specialization_vuzSpecId",
            //    table: "Vuz_Specialization",
            //    column: "vuzSpecId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vuz_SSUZ_Spec_ssuzSpecId",
            //    table: "Vuz_SSUZ_Spec",
            //    column: "ssuzSpecId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abitur_Ocenki");

            migrationBuilder.DropTable(
                name: "Abitur_Polupr");

            migrationBuilder.DropTable(
                name: "Abitur_RegStep_ChangeLog");

            migrationBuilder.DropTable(
                name: "Abitur_Zayvl");

            migrationBuilder.DropTable(
                name: "Accept");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserPasskeys");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConsentForPDP");

            migrationBuilder.DropTable(
                name: "CT_Certificaty");

            migrationBuilder.DropTable(
                name: "EntrantsOfInnerExams");

            migrationBuilder.DropTable(
                name: "ExamType_100_ballov");

            migrationBuilder.DropTable(
                name: "Gragdanstvo");

            migrationBuilder.DropTable(
                name: "GroupsOfSpecialities_Relationships");

            migrationBuilder.DropTable(
                name: "Obr_SrBal5_10");

            migrationBuilder.DropTable(
                name: "Permission_User");

            migrationBuilder.DropTable(
                name: "Place_AfterAccept");

            migrationBuilder.DropTable(
                name: "Place_User");

            migrationBuilder.DropTable(
                name: "Register");

            migrationBuilder.DropTable(
                name: "Tables_abiturs");

            migrationBuilder.DropTable(
                name: "Tables_logs");

            migrationBuilder.DropTable(
                name: "Tables_tableToQueue");

            migrationBuilder.DropTable(
                name: "Vuz_Spec_Ekz");

            migrationBuilder.DropTable(
                name: "Vuz_Specialization");

            migrationBuilder.DropTable(
                name: "Vuz_SSUZ_Spec");

            migrationBuilder.DropTable(
                name: "Lgoty_Polupr");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ConsentPDP");

            migrationBuilder.DropTable(
                name: "Abitur");

            migrationBuilder.DropTable(
                name: "CT_Uchastniki");

            migrationBuilder.DropTable(
                name: "Tables_queues");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "OKSK_Spec_Specialization");

            migrationBuilder.DropTable(
                name: "SSUZ_Spec");

            migrationBuilder.DropTable(
                name: "PassportType");

            migrationBuilder.DropTable(
                name: "Lgoti_BezEkz");

            migrationBuilder.DropTable(
                name: "Lgoti_VneKonk");

            migrationBuilder.DropTable(
                name: "Obr_DokType");

            migrationBuilder.DropTable(
                name: "Obr_Uchregd");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "Spetialization_grade");

            migrationBuilder.DropTable(
                name: "Vuz_Spec");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tables_states");

            migrationBuilder.DropTable(
                name: "ExamType");

            migrationBuilder.DropTable(
                name: "OKSK_Specialization");

            migrationBuilder.DropTable(
                name: "Obr_Uroven");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OKSK_Spec");

            migrationBuilder.DropTable(
                name: "Obr_Vid");

            migrationBuilder.DropTable(
                name: "GroupOfSpecialities");

            migrationBuilder.DropTable(
                name: "StatSpecGroup");

            migrationBuilder.DropTable(
                name: "Vuz");

            migrationBuilder.DropTable(
                name: "Vuz_Faclt");

            migrationBuilder.DropTable(
                name: "Vuz_Srok");

            migrationBuilder.DropTable(
                name: "Obr_Froma");
        }
    }
}
