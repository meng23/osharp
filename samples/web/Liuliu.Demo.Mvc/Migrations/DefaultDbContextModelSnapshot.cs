﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSharp.Entity;

namespace Liuliu.Demo.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("OSharp.Authorization.EntityInfos.EntityInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("AuditEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PropertyJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TypeName")
                        .IsUnique()
                        .HasName("ClassFullNameIndex");

                    b.ToTable("Auth_EntityInfo");
                });

            modelBuilder.Entity("OSharp.Authorization.Functions.Function", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<string>("Area")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AuditEntityEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AuditOperationEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CacheExpirationSeconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Controller")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAccessTypeChanged")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAjax")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCacheSliding")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsController")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Area", "Controller", "Action")
                        .IsUnique()
                        .HasName("AreaControllerActionIndex");

                    b.ToTable("Auth_Function");
                });

            modelBuilder.Entity("OSharp.Core.Systems.KeyValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ValueJson")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValueType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Systems_KeyValue");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.EntityRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilterGroupJson")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Operation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("EntityId", "RoleId", "Operation")
                        .IsUnique()
                        .HasName("EntityRoleIndex");

                    b.ToTable("Auth_EntityRole");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.EntityUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EntityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FilterGroupJson")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("EntityId", "UserId")
                        .HasName("EntityUserIndex");

                    b.ToTable("Auth_EntityUser");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("OrderCode")
                        .HasColumnType("REAL");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT");

                    b.Property<string>("TreePathString")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Auth_Module");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.ModuleFunction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("FunctionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModuleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("ModuleId", "FunctionId")
                        .IsUnique()
                        .HasName("ModuleFunctionIndex");

                    b.ToTable("Auth_ModuleFunction");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.ModuleRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ModuleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("ModuleId", "RoleId")
                        .IsUnique()
                        .HasName("ModuleRoleIndex");

                    b.ToTable("Auth_ModuleRole");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.ModuleUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ModuleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("ModuleId", "UserId")
                        .IsUnique()
                        .HasName("ModuleUserIndex");

                    b.ToTable("Auth_ModuleUser");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.LoginLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ip")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LogoutTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserAgent")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Identity_LoginLog");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Identity_Organization");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("NormalizedName", "DeletedTime")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Identity_Role");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Identity_RoleClaim");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HeadImg")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NickName")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizeEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("NormalizeEmail", "DeletedTime")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName", "DeletedTime")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Identity_User");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Identity_UserClaim");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegisterIp")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Identity_UserDetail");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Avatar")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("LoginProvider", "ProviderKey")
                        .IsUnique()
                        .HasName("UserLoginIndex");

                    b.ToTable("Identity_UserLogin");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId", "DeletedTime")
                        .IsUnique()
                        .HasName("UserRoleIndex");

                    b.ToTable("Identity_UserRole");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "LoginProvider", "Name")
                        .IsUnique()
                        .HasName("UserTokenIndex");

                    b.ToTable("Identity_UserToken");
                });

            modelBuilder.Entity("OSharp.Hosting.Infos.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BeginDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CanReply")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSended")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MessageType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NewReplyCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("Infos_Message");
                });

            modelBuilder.Entity("OSharp.Hosting.Infos.Entities.MessageReceive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<int>("NewReplyCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReadDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Infos_MessageReceive");
                });

            modelBuilder.Entity("OSharp.Hosting.Infos.Entities.MessageReply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BelongMessageId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ParentMessageId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ParentReplyId")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BelongMessageId");

                    b.HasIndex("ParentMessageId");

                    b.HasIndex("ParentReplyId");

                    b.HasIndex("UserId");

                    b.ToTable("Infos_MessageReply");
                });

            modelBuilder.Entity("OSharp.Hosting.Systems.Entities.AuditEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EntityKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OperateType")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("OperationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("Systems_AuditEntity");
                });

            modelBuilder.Entity("OSharp.Hosting.Systems.Entities.AuditOperation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Browser")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Elapsed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FunctionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ip")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("NickName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OperationSystem")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResultType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserAgent")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Systems_AuditOperation");
                });

            modelBuilder.Entity("OSharp.Hosting.Systems.Entities.AuditProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AuditEntityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataType")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FieldName")
                        .HasColumnType("TEXT");

                    b.Property<string>("NewValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginalValue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuditEntityId");

                    b.ToTable("Systems_AuditProperty");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.EntityRole", b =>
                {
                    b.HasOne("OSharp.Authorization.EntityInfos.EntityInfo", "EntityInfo")
                        .WithMany()
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.EntityUser", b =>
                {
                    b.HasOne("OSharp.Authorization.EntityInfos.EntityInfo", "EntityInfo")
                        .WithMany()
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.Module", b =>
                {
                    b.HasOne("OSharp.Hosting.Authorization.Entities.Module", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.ModuleFunction", b =>
                {
                    b.HasOne("OSharp.Authorization.Functions.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Authorization.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.ModuleRole", b =>
                {
                    b.HasOne("OSharp.Hosting.Authorization.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Authorization.Entities.ModuleUser", b =>
                {
                    b.HasOne("OSharp.Hosting.Authorization.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.LoginLog", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.Organization", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.Organization", null)
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.Role", b =>
                {
                    b.HasOne("OSharp.Hosting.Infos.Entities.Message", null)
                        .WithMany("PublicRoles")
                        .HasForeignKey("MessageId");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.RoleClaim", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.User", b =>
                {
                    b.HasOne("OSharp.Hosting.Infos.Entities.Message", null)
                        .WithMany("Recipients")
                        .HasForeignKey("MessageId");
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserClaim", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserDetail", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("OSharp.Hosting.Identity.Entities.UserDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserLogin", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserRole", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Identity.Entities.UserToken", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Infos.Entities.Message", b =>
                {
                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Infos.Entities.MessageReceive", b =>
                {
                    b.HasOne("OSharp.Hosting.Infos.Entities.Message", "Message")
                        .WithMany("Receives")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Infos.Entities.MessageReply", b =>
                {
                    b.HasOne("OSharp.Hosting.Infos.Entities.Message", "BelongMessage")
                        .WithMany()
                        .HasForeignKey("BelongMessageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Infos.Entities.Message", "ParentMessage")
                        .WithMany("Replies")
                        .HasForeignKey("ParentMessageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Infos.Entities.MessageReply", "ParentReply")
                        .WithMany("Replies")
                        .HasForeignKey("ParentReplyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OSharp.Hosting.Identity.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Systems.Entities.AuditEntity", b =>
                {
                    b.HasOne("OSharp.Hosting.Systems.Entities.AuditOperation", "Operation")
                        .WithMany("AuditEntities")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OSharp.Hosting.Systems.Entities.AuditProperty", b =>
                {
                    b.HasOne("OSharp.Hosting.Systems.Entities.AuditEntity", "AuditEntity")
                        .WithMany("Properties")
                        .HasForeignKey("AuditEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}