using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F_Ferias.AccessData.Data.Migrations
{
    public partial class models_migration_0811024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actividad_Economica_Feria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividad_Economica_Feria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "actividades_Complementarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actividades_Complementarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aplicativo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplicativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clasificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clasificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cp_Cepomex_Mexico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    d_codigo = table.Column<string>(type: "text", nullable: true),
                    d_asenta = table.Column<string>(type: "text", nullable: true),
                    d_tipo_asenta = table.Column<string>(type: "text", nullable: true),
                    D_mnpio = table.Column<string>(type: "text", nullable: true),
                    d_estado = table.Column<string>(type: "text", nullable: true),
                    d_ciudad = table.Column<string>(type: "text", nullable: true),
                    d_CP = table.Column<string>(type: "text", nullable: true),
                    c_estado = table.Column<string>(type: "text", nullable: true),
                    c_oficina = table.Column<string>(type: "text", nullable: true),
                    c_CP = table.Column<string>(type: "text", nullable: true),
                    c_tipo_asenta = table.Column<string>(type: "text", nullable: true),
                    c_mnpio = table.Column<string>(type: "text", nullable: true),
                    id_asenta_cpcons = table.Column<string>(type: "text", nullable: true),
                    d_zona = table.Column<string>(type: "text", nullable: true),
                    c_cve_ciudad = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cp_Cepomex_Mexico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "entidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Pais = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Iniciales = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feria_Modalidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feria_Modalidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feria_Tamanio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feria_Tamanio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ferias_Estatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Idescripcion = table.Column<string>(type: "text", nullable: true),
                    estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias_Estatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poblacion_Especifica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poblacion_Especifica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Evento_Feria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Evento_Feria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<int>(type: "integer", nullable: false),
                    estatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Propietario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Recurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Recurso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDiscapacidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Estatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDiscapacidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_aplicativo = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modulo_Aplicativo_id_aplicativo",
                        column: x => x.id_aplicativo,
                        principalTable: "Aplicativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ferias_Nacional",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    hora_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    hora_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    feria_logo = table.Column<byte>(type: "smallint", nullable: false),
                    estatus = table.Column<int>(type: "integer", nullable: false),
                    entidades_todas = table.Column<bool>(type: "boolean", nullable: false),
                    Dataentidades_selection = table.Column<string>(type: "jsonb", nullable: true),
                    create_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    update_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_create = table.Column<int>(type: "integer", nullable: false),
                    user_upddel = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias_Nacional", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ferias_Nacional_AspNetUsers_user_create",
                        column: x => x.user_create,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Nacional_AspNetUsers_user_upddel",
                        column: x => x.user_upddel,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ferias_Nacional_Ferias_Estatus_estatus",
                        column: x => x.estatus,
                        principalTable: "Ferias_Estatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oficina",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_oficina = table.Column<string>(type: "text", nullable: true),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    id_entidad = table.Column<int>(type: "integer", nullable: false),
                    id_ubicacion = table.Column<int>(type: "integer", nullable: false),
                    horario = table.Column<string>(type: "text", nullable: true),
                    correo_electronico = table.Column<string>(type: "text", nullable: true),
                    telefono = table.Column<string>(type: "text", nullable: true),
                    id_usuario_encargado = table.Column<int>(type: "integer", nullable: true),
                    encargado = table.Column<string>(type: "text", nullable: true),
                    user_create = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_upddel = table.Column<string>(type: "text", nullable: true),
                    estatus = table.Column<int>(type: "integer", nullable: false),
                    plataforma_utilizar = table.Column<string>(type: "text", nullable: true),
                    identificador = table.Column<string>(type: "text", nullable: true),
                    tipo_espacio = table.Column<int>(type: "integer", nullable: true),
                    fecha_ini = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    id_responsable = table.Column<int>(type: "integer", nullable: true),
                    id_consejero_asignado = table.Column<int>(type: "integer", nullable: true),
                    id_osne_encargada = table.Column<int>(type: "integer", nullable: true),
                    es_usne = table.Column<bool>(type: "boolean", nullable: true),
                    colonia_mostrar = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficina", x => x.id);
                    table.ForeignKey(
                        name: "FK_Oficina_AspNetUsers_id_usuario_encargado",
                        column: x => x.id_usuario_encargado,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Oficina_AspNetUsers_user_create",
                        column: x => x.user_create,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oficina_entidades_id_entidad",
                        column: x => x.id_entidad,
                        principalTable: "entidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oficina_Ferias_Estatus_estatus",
                        column: x => x.estatus,
                        principalTable: "Ferias_Estatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feria_Inversion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    observacion_promocion = table.Column<string>(type: "text", nullable: true),
                    cantidad_promocion = table.Column<float>(type: "real", nullable: false),
                    observacion_acondicionamiento = table.Column<string>(type: "text", nullable: true),
                    cantidad_acondicionamiento = table.Column<float>(type: "real", nullable: false),
                    observacion_infraestructura_computo = table.Column<string>(type: "text", nullable: true),
                    cantidad_infraestructura_computo = table.Column<float>(type: "real", nullable: false),
                    observacion_alquiler = table.Column<string>(type: "text", nullable: true),
                    cantidad_alquiler = table.Column<float>(type: "real", nullable: false),
                    observacion_alimentos_bebidas = table.Column<string>(type: "text", nullable: true),
                    cantidad_alimentos_bebidas = table.Column<float>(type: "real", nullable: false),
                    id_tipo_recurso = table.Column<int>(type: "integer", nullable: false),
                    estatus = table.Column<int>(type: "integer", nullable: false),
                    observacion_promocion_est = table.Column<string>(type: "text", nullable: true),
                    cantidad_promocion_est = table.Column<float>(type: "real", nullable: false),
                    observacion_acondicionamiento_est = table.Column<string>(type: "text", nullable: true),
                    cantidad_acondicionamiento_est = table.Column<float>(type: "real", nullable: false),
                    observacion_infraestructura_computo_est = table.Column<string>(type: "text", nullable: true),
                    cantidad_infraestructura_computo_est = table.Column<float>(type: "real", nullable: false),
                    observacion_alquiler_est = table.Column<string>(type: "text", nullable: true),
                    cantidad_alquiler_est = table.Column<float>(type: "real", nullable: false),
                    observacion_alimentos_bebidas_est = table.Column<string>(type: "text", nullable: true),
                    cantidad_alimentos_bebidas_est = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feria_Inversion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Feria_Inversion_Tipo_Recurso_id_tipo_recurso",
                        column: x => x.id_tipo_recurso,
                        principalTable: "Tipo_Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    primer_apellido = table.Column<string>(type: "text", nullable: true),
                    segundo_apellido = table.Column<string>(type: "text", nullable: true),
                    fecha_nacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    entidad_nacimiento = table.Column<int>(type: "integer", nullable: false),
                    nacionalidad = table.Column<int>(type: "integer", nullable: false),
                    genero = table.Column<string>(type: "text", nullable: true),
                    correo_electronico = table.Column<string>(type: "text", nullable: true),
                    curp = table.Column<string>(type: "text", nullable: true),
                    tipo_telefono = table.Column<string>(type: "text", nullable: true),
                    telefono = table.Column<string>(type: "text", nullable: true),
                    id_ubicacion = table.Column<int>(type: "integer", nullable: true),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    id_tipodiscapacidad = table.Column<int>(type: "integer", nullable: true),
                    atencion_preferente = table.Column<bool>(type: "boolean", nullable: false),
                    atencion_preferencial = table.Column<int>(type: "integer", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    acepto_terminos = table.Column<bool>(type: "boolean", nullable: false),
                    datos_correctos = table.Column<bool>(type: "boolean", nullable: false),
                    acepto_arco = table.Column<bool>(type: "boolean", nullable: false),
                    acepto_ofertas = table.Column<bool>(type: "boolean", nullable: false),
                    contacto_portal = table.Column<bool>(type: "boolean", nullable: false),
                    contacto_telefonico = table.Column<bool>(type: "boolean", nullable: false),
                    contacto_correo = table.Column<bool>(type: "boolean", nullable: false),
                    estatus = table.Column<int>(type: "integer", nullable: false),
                    siisne_tipo_persona = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    contactar_portal = table.Column<bool>(type: "boolean", nullable: false),
                    siine_tipo_persona = table.Column<string>(type: "text", nullable: true),
                    correo_electronico_inhabilitado = table.Column<string>(type: "text", nullable: true),
                    curp_inhabilitado = table.Column<string>(type: "text", nullable: true),
                    user_create = table.Column<string>(type: "text", nullable: true),
                    user_upddel = table.Column<string>(type: "text", nullable: true),
                    motivo_inhabilitacion = table.Column<string>(type: "text", nullable: true),
                    estatus_pcm = table.Column<int>(type: "integer", nullable: false),
                    pcm_whatsapp = table.Column<string>(type: "text", nullable: true),
                    pcm_entidad_reside = table.Column<int>(type: "integer", nullable: false),
                    pcm_municipio_reside = table.Column<int>(type: "integer", nullable: false),
                    pcm_necesita_visa_trabajar = table.Column<bool>(type: "boolean", nullable: false),
                    id_pais_lada_telefono = table.Column<string>(type: "text", nullable: true),
                    id_pais_lada_whatsapp = table.Column<string>(type: "text", nullable: true),
                    foto = table.Column<byte>(type: "smallint", nullable: false),
                    archivo_foto = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persona_AspNetUsers_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_TipoDiscapacidad_id_tipodiscapacidad",
                        column: x => x.id_tipodiscapacidad,
                        principalTable: "TipoDiscapacidad",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "accion_Por_Modulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_modulo = table.Column<int>(type: "integer", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accion_Por_Modulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accion_Por_Modulo_Modulo_id_modulo",
                        column: x => x.id_modulo,
                        principalTable: "Modulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "abc_Directorio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_actualizacion = table.Column<string>(type: "text", nullable: true),
                    consecutivo = table.Column<int>(type: "integer", nullable: false),
                    id_entidad = table.Column<int>(type: "integer", nullable: false),
                    entidad = table.Column<string>(type: "text", nullable: true),
                    tipo_oficina = table.Column<string>(type: "text", nullable: true),
                    id_oficina = table.Column<int>(type: "integer", nullable: false),
                    accion = table.Column<string>(type: "text", nullable: true),
                    cdep_id = table.Column<int>(type: "integer", nullable: false),
                    nom_oficina = table.Column<string>(type: "text", nullable: true),
                    oficina_historico = table.Column<string>(type: "text", nullable: true),
                    domicilio = table.Column<string>(type: "text", nullable: true),
                    t_asentamiento = table.Column<string>(type: "text", nullable: true),
                    colonia_mostrar = table.Column<string>(type: "text", nullable: true),
                    localidad = table.Column<string>(type: "text", nullable: true),
                    municipio = table.Column<string>(type: "text", nullable: true),
                    cp = table.Column<string>(type: "text", nullable: true),
                    id_municipio = table.Column<int>(type: "integer", nullable: false),
                    id_codigopostal = table.Column<int>(type: "integer", nullable: false),
                    id_colonia = table.Column<int>(type: "integer", nullable: false),
                    colonia_correcta = table.Column<string>(type: "text", nullable: true),
                    verificar_colonia = table.Column<string>(type: "text", nullable: true),
                    entre_calleuno = table.Column<string>(type: "text", nullable: true),
                    entre_calledos = table.Column<string>(type: "text", nullable: true),
                    referencia = table.Column<string>(type: "text", nullable: true),
                    latitud = table.Column<string>(type: "text", nullable: true),
                    longitud = table.Column<string>(type: "text", nullable: true),
                    responsable = table.Column<string>(type: "text", nullable: true),
                    t_contacto = table.Column<string>(type: "text", nullable: true),
                    c_contacto = table.Column<string>(type: "text", nullable: true),
                    h_atencion = table.Column<string>(type: "text", nullable: true),
                    d_atencion = table.Column<string>(type: "text", nullable: true),
                    vid_valida = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abc_Directorio", x => x.id);
                    table.ForeignKey(
                        name: "FK_abc_Directorio_entidades_id_entidad",
                        column: x => x.id_entidad,
                        principalTable: "entidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_abc_Directorio_Oficina_id_oficina",
                        column: x => x.id_oficina,
                        principalTable: "Oficina",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "C_FUNCIONARIOS_PORTALEMPLEO",
                columns: table => new
                {
                    CEDO_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ESTADO = table.Column<string>(type: "text", nullable: true),
                    DEPENDENCIA = table.Column<string>(type: "text", nullable: true),
                    ID = table.Column<int>(type: "integer", nullable: false),
                    NOMBRE = table.Column<string>(type: "text", nullable: true),
                    APELLIDOP = table.Column<string>(type: "text", nullable: true),
                    APELLIDOM = table.Column<string>(type: "text", nullable: true),
                    CARGO = table.Column<string>(type: "text", nullable: true),
                    PUESTO = table.Column<string>(type: "text", nullable: true),
                    RECURSO = table.Column<string>(type: "text", nullable: true),
                    EMAIL = table.Column<string>(type: "text", nullable: true),
                    TELEFONO = table.Column<string>(type: "text", nullable: true),
                    TITULO = table.Column<string>(type: "text", nullable: true),
                    CURP = table.Column<string>(type: "text", nullable: true),
                    TIPO = table.Column<string>(type: "text", nullable: true),
                    AREA = table.Column<string>(type: "text", nullable: true),
                    TELEFONO_OSNE = table.Column<string>(type: "text", nullable: true),
                    id_oficina = table.Column<int>(type: "integer", nullable: true),
                    id_usuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C_FUNCIONARIOS_PORTALEMPLEO", x => x.CEDO_ID);
                    table.ForeignKey(
                        name: "FK_C_FUNCIONARIOS_PORTALEMPLEO_AspNetUsers_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C_FUNCIONARIOS_PORTALEMPLEO_Oficina_id_oficina",
                        column: x => x.id_oficina,
                        principalTable: "Oficina",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "bitacora_Evento",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    accion = table.Column<int>(type: "integer", nullable: false),
                    id_modulo = table.Column<int>(type: "integer", nullable: false),
                    id_usuario = table.Column<int>(type: "integer", nullable: false),
                    id_propietario = table.Column<int>(type: "integer", nullable: false),
                    fecha_reg = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    hora_reg = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    datos = table.Column<string>(type: "jsonb", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bitacora_Evento", x => x.id);
                    table.ForeignKey(
                        name: "FK_bitacora_Evento_accion_Por_Modulo_accion",
                        column: x => x.accion,
                        principalTable: "accion_Por_Modulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bitacora_Evento_AspNetUsers_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bitacora_Evento_Modulo_id_modulo",
                        column: x => x.id_modulo,
                        principalTable: "Modulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bitacora_Evento_Tipo_Propietario_id_propietario",
                        column: x => x.id_propietario,
                        principalTable: "Tipo_Propietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ferias_Empleo_Local",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titulo = table.Column<string>(type: "text", nullable: true),
                    comentario = table.Column<string>(type: "text", nullable: true),
                    direccion = table.Column<string>(type: "text", nullable: true),
                    id_ubicacion = table.Column<int>(type: "integer", nullable: false),
                    fecha_ini = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_create = table.Column<int>(type: "integer", nullable: false),
                    user_upddel = table.Column<int>(type: "integer", nullable: true),
                    estatus = table.Column<int>(type: "integer", nullable: false),
                    es_nacional = table.Column<bool>(type: "boolean", nullable: false),
                    id_feria_nacional = table.Column<int>(type: "integer", nullable: true),
                    modalidad = table.Column<int>(type: "integer", nullable: false),
                    es_usne = table.Column<bool>(type: "boolean", nullable: false),
                    es_osne = table.Column<bool>(type: "boolean", nullable: false),
                    id_entidad = table.Column<int>(type: "integer", nullable: false),
                    id_unidadresponsable = table.Column<int>(type: "integer", nullable: false),
                    hora_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    hora_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    es_virtual = table.Column<bool>(type: "boolean", nullable: false),
                    plataforma = table.Column<string>(type: "text", nullable: true),
                    plataforma_evento = table.Column<string>(type: "text", nullable: true),
                    plataforma_contrasena = table.Column<string>(type: "text", nullable: true),
                    plataforma_url = table.Column<string>(type: "text", nullable: true),
                    fecha_publicacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_pre_registro_empresa = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_pre_registro_buscador = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_max_asistencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_max_participantes = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    id_tipo_recurso = table.Column<int>(type: "integer", nullable: false),
                    id_actividad_complementaria = table.Column<int>(type: "integer", nullable: false),
                    otra_actividad = table.Column<string>(type: "text", nullable: true),
                    otra_tipo_recurso = table.Column<string>(type: "text", nullable: true),
                    zona = table.Column<int>(type: "integer", nullable: false),
                    vialidad = table.Column<int>(type: "integer", nullable: false),
                    asentamiento = table.Column<int>(type: "integer", nullable: false),
                    clasificacion = table.Column<int>(type: "integer", nullable: false),
                    actividad_economica = table.Column<int>(type: "integer", nullable: false),
                    otra_actividad_economica = table.Column<string>(type: "text", nullable: true),
                    tipo_evento = table.Column<int>(type: "integer", nullable: false),
                    poblacion_especifica = table.Column<int>(type: "integer", nullable: false),
                    otros_tipo_poblacion = table.Column<string>(type: "text", nullable: true),
                    instalacion_nuevas_empresas = table.Column<bool>(type: "boolean", nullable: false),
                    puesto_nueva_creacion = table.Column<bool>(type: "boolean", nullable: false),
                    mano_obra_emporada = table.Column<bool>(type: "boolean", nullable: false),
                    rotacion_personal = table.Column<bool>(type: "boolean", nullable: false),
                    otra_justificacion = table.Column<bool>(type: "boolean", nullable: false),
                    otros_tipo_justificacion = table.Column<string>(type: "text", nullable: true),
                    asiste_empresas = table.Column<int>(type: "integer", nullable: false),
                    asiste_oferta_empleo = table.Column<int>(type: "integer", nullable: false),
                    asiste_solicitan_empleo = table.Column<int>(type: "integer", nullable: false),
                    asiste_solicitan_colocado = table.Column<int>(type: "integer", nullable: false),
                    feria_logo = table.Column<byte>(type: "smallint", nullable: false),
                    misma_cede = table.Column<bool>(type: "boolean", nullable: false),
                    publicacion = table.Column<bool>(type: "boolean", nullable: false),
                    id_feriatamanio = table.Column<int>(type: "integer", nullable: false),
                    sede_evento = table.Column<string>(type: "text", nullable: true),
                    id_feria_inversion = table.Column<int>(type: "integer", nullable: true),
                    notificacion_enviada = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferias_Empleo_Local", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_abc_Directorio_id_unidadresponsable",
                        column: x => x.id_unidadresponsable,
                        principalTable: "abc_Directorio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_actividad_Economica_Feria_actividad_eco~",
                        column: x => x.actividad_economica,
                        principalTable: "actividad_Economica_Feria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_AspNetUsers_user_create",
                        column: x => x.user_create,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_AspNetUsers_user_upddel",
                        column: x => x.user_upddel,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_clasificacion_clasificacion",
                        column: x => x.clasificacion,
                        principalTable: "clasificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_entidades_id_entidad",
                        column: x => x.id_entidad,
                        principalTable: "entidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Feria_Inversion_id_feria_inversion",
                        column: x => x.id_feria_inversion,
                        principalTable: "Feria_Inversion",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Feria_Modalidad_modalidad",
                        column: x => x.modalidad,
                        principalTable: "Feria_Modalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Feria_Tamanio_id_feriatamanio",
                        column: x => x.id_feriatamanio,
                        principalTable: "Feria_Tamanio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Ferias_Estatus_estatus",
                        column: x => x.estatus,
                        principalTable: "Ferias_Estatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Ferias_Nacional_id_feria_nacional",
                        column: x => x.id_feria_nacional,
                        principalTable: "Ferias_Nacional",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Poblacion_Especifica_poblacion_especifi~",
                        column: x => x.poblacion_especifica,
                        principalTable: "Poblacion_Especifica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Tipo_Evento_Feria_tipo_evento",
                        column: x => x.tipo_evento,
                        principalTable: "Tipo_Evento_Feria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_actividad_complementaria",
                        column: x => x.id_actividad_complementaria,
                        principalTable: "Tipo_Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ferias_Empleo_Local_Tipo_Recurso_id_tipo_recurso",
                        column: x => x.id_tipo_recurso,
                        principalTable: "Tipo_Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feria_Actividad_Complementaria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_feria = table.Column<int>(type: "integer", nullable: false),
                    id_actividad_complementaria = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feria_Actividad_Complementaria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feria_Actividad_Complementaria_actividades_Complementarias_~",
                        column: x => x.id_actividad_complementaria,
                        principalTable: "actividades_Complementarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feria_Actividad_Complementaria_Ferias_Empleo_Local_id_feria",
                        column: x => x.id_feria,
                        principalTable: "Ferias_Empleo_Local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_abc_Directorio_id_entidad",
                table: "abc_Directorio",
                column: "id_entidad");

            migrationBuilder.CreateIndex(
                name: "IX_abc_Directorio_id_oficina",
                table: "abc_Directorio",
                column: "id_oficina");

            migrationBuilder.CreateIndex(
                name: "IX_accion_Por_Modulo_id_modulo",
                table: "accion_Por_Modulo",
                column: "id_modulo");

            migrationBuilder.CreateIndex(
                name: "IX_bitacora_Evento_accion",
                table: "bitacora_Evento",
                column: "accion");

            migrationBuilder.CreateIndex(
                name: "IX_bitacora_Evento_id_modulo",
                table: "bitacora_Evento",
                column: "id_modulo");

            migrationBuilder.CreateIndex(
                name: "IX_bitacora_Evento_id_propietario",
                table: "bitacora_Evento",
                column: "id_propietario");

            migrationBuilder.CreateIndex(
                name: "IX_bitacora_Evento_id_usuario",
                table: "bitacora_Evento",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_C_FUNCIONARIOS_PORTALEMPLEO_id_oficina",
                table: "C_FUNCIONARIOS_PORTALEMPLEO",
                column: "id_oficina");

            migrationBuilder.CreateIndex(
                name: "IX_C_FUNCIONARIOS_PORTALEMPLEO_id_usuario",
                table: "C_FUNCIONARIOS_PORTALEMPLEO",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Feria_Actividad_Complementaria_id_actividad_complementaria",
                table: "Feria_Actividad_Complementaria",
                column: "id_actividad_complementaria");

            migrationBuilder.CreateIndex(
                name: "IX_Feria_Actividad_Complementaria_id_feria",
                table: "Feria_Actividad_Complementaria",
                column: "id_feria");

            migrationBuilder.CreateIndex(
                name: "IX_Feria_Inversion_id_tipo_recurso",
                table: "Feria_Inversion",
                column: "id_tipo_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_actividad_economica",
                table: "Ferias_Empleo_Local",
                column: "actividad_economica");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_clasificacion",
                table: "Ferias_Empleo_Local",
                column: "clasificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_estatus",
                table: "Ferias_Empleo_Local",
                column: "estatus");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_actividad_complementaria",
                table: "Ferias_Empleo_Local",
                column: "id_actividad_complementaria");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_entidad",
                table: "Ferias_Empleo_Local",
                column: "id_entidad");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_inversion",
                table: "Ferias_Empleo_Local",
                column: "id_feria_inversion");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_feria_nacional",
                table: "Ferias_Empleo_Local",
                column: "id_feria_nacional");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_feriatamanio",
                table: "Ferias_Empleo_Local",
                column: "id_feriatamanio");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_tipo_recurso",
                table: "Ferias_Empleo_Local",
                column: "id_tipo_recurso");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_id_unidadresponsable",
                table: "Ferias_Empleo_Local",
                column: "id_unidadresponsable");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_modalidad",
                table: "Ferias_Empleo_Local",
                column: "modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_poblacion_especifica",
                table: "Ferias_Empleo_Local",
                column: "poblacion_especifica");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_tipo_evento",
                table: "Ferias_Empleo_Local",
                column: "tipo_evento");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_user_create",
                table: "Ferias_Empleo_Local",
                column: "user_create");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Empleo_Local_user_upddel",
                table: "Ferias_Empleo_Local",
                column: "user_upddel");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Nacional_estatus",
                table: "Ferias_Nacional",
                column: "estatus");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Nacional_user_create",
                table: "Ferias_Nacional",
                column: "user_create");

            migrationBuilder.CreateIndex(
                name: "IX_Ferias_Nacional_user_upddel",
                table: "Ferias_Nacional",
                column: "user_upddel");

            migrationBuilder.CreateIndex(
                name: "IX_Modulo_id_aplicativo",
                table: "Modulo",
                column: "id_aplicativo");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_estatus",
                table: "Oficina",
                column: "estatus");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_id_entidad",
                table: "Oficina",
                column: "id_entidad");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_id_usuario_encargado",
                table: "Oficina",
                column: "id_usuario_encargado");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_user_create",
                table: "Oficina",
                column: "user_create");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_id_tipodiscapacidad",
                table: "Persona",
                column: "id_tipodiscapacidad");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_id_usuario",
                table: "Persona",
                column: "id_usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bitacora_Evento");

            migrationBuilder.DropTable(
                name: "C_FUNCIONARIOS_PORTALEMPLEO");

            migrationBuilder.DropTable(
                name: "cp_Cepomex_Mexico");

            migrationBuilder.DropTable(
                name: "Feria_Actividad_Complementaria");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "accion_Por_Modulo");

            migrationBuilder.DropTable(
                name: "Tipo_Propietario");

            migrationBuilder.DropTable(
                name: "actividades_Complementarias");

            migrationBuilder.DropTable(
                name: "Ferias_Empleo_Local");

            migrationBuilder.DropTable(
                name: "TipoDiscapacidad");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "abc_Directorio");

            migrationBuilder.DropTable(
                name: "actividad_Economica_Feria");

            migrationBuilder.DropTable(
                name: "clasificacion");

            migrationBuilder.DropTable(
                name: "Feria_Inversion");

            migrationBuilder.DropTable(
                name: "Feria_Modalidad");

            migrationBuilder.DropTable(
                name: "Feria_Tamanio");

            migrationBuilder.DropTable(
                name: "Ferias_Nacional");

            migrationBuilder.DropTable(
                name: "Poblacion_Especifica");

            migrationBuilder.DropTable(
                name: "Tipo_Evento_Feria");

            migrationBuilder.DropTable(
                name: "Aplicativo");

            migrationBuilder.DropTable(
                name: "Oficina");

            migrationBuilder.DropTable(
                name: "Tipo_Recurso");

            migrationBuilder.DropTable(
                name: "entidades");

            migrationBuilder.DropTable(
                name: "Ferias_Estatus");
        }
    }
}
