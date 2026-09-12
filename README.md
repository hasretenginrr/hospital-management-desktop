# Hospital Management Desktop App

[English](#overview) | [Türkçe](#türkçe)

## Overview

A C# Windows Forms application for managing hospital-related records: doctors, patients, appointments, patient complaints, diagnoses, and medications linked to appointments.

The interface is in Turkish. This is an educational desktop project, not a web application or a production-ready clinical system. Use synthetic test data only.

## Technology Stack

| Technology | Purpose |
| --- | --- |
| C# / Windows Forms | Desktop interface and event handlers |
| .NET Framework 4.7.2 | Target framework |
| Entity Framework 6.5.1 | Database access |
| EDMX / Database First | Entity and database mappings |
| SQL Server | Relational database |
| LINQ | Record queries and filtering |
| Typed DataSets / BindingSource | Designer-generated data bindings |

This project uses Entity Framework 6, **not EF Core**, and .NET Framework, **not ASP.NET Core**.

## Features in the Source

- Login checks against doctor, secretary, and patient records.
- Role-dependent screens and appointment filtering.
- Doctor listing, creation, updates, specialty selection, and active/inactive status.
- Patient listing, creation, updates, and deletion.
- Appointment listing, creation, updates, and deletion.
- Recording patient complaints and diagnoses on appointments.
- Associating medications with appointments and displaying linked medication records.

Access restrictions are implemented through UI controls and query filters; they should not be treated as a complete authorization system.

## Project Guide

| File / group | Responsibility |
| --- | --- |
| `ilk.sln` | Visual Studio solution |
| `ilk/ilk.csproj` | Windows Forms project |
| `ilk/Program.cs` | Starts the login form |
| `ilk/FrmLogin.cs` | Login checks |
| `ilk/FrmHastaneGiris.cs` | Main menu and role-dependent controls |
| `ilk/FrmDoktor*.cs` | Doctor forms |
| `ilk/FrmHastaEkle.cs`, `ilk/FrmHastaListele.cs` | Patient forms |
| `ilk/FrmRandevu*.cs` | Appointment forms |
| `ilk/FrmTeşhisler.cs` | Complaint, diagnosis, and medication entries |
| `ilk/Model1.edmx` | Database First model |
| `ilk/App.config` | Database connections and EF configuration |
| `SQLQuery1.sql`, `SQLQuery2.sql`, `aa.sql` | SQL snippets, not a full database installer |

The original solution name and namespace, `ilk`, have been retained.

## Database Dependencies

The application expects a SQL Server database named `HastaneProje`, with objects matching the EDMX model.

| Object | Purpose |
| --- | --- |
| `Tbl_Branslar` | Specialties |
| `Tbl_Doktorlar` | Doctors |
| `Tbl_Hastalar` | Patients |
| `Tbl_Sekreter` | Secretary login records |
| `Tbl_Randevular` | Appointments, complaints, and diagnoses |
| `Tbl_ilaclar` | Medications |
| `Tbl_Kayitlar` | Appointment–medication associations |
| `vDoktorlar`, `vRandevu`, `vIlaclar` | Views consumed by forms |

**A complete database creation script or backup is not included.** An empty database alone will not make the application functional. Obtain a sanitized schema export from the original database, or reconstruct and verify the required tables, relationships, and views against the model.

## Setup Prerequisites

1. Use Windows with Visual Studio, the **.NET desktop development** workload, and the .NET Framework 4.7.2 targeting/developer pack.
2. Clone the repository using its current URL from GitHub's **Code** menu.
3. Open `ilk.sln` and restore NuGet packages.
4. Resolve missing project resources before building. The project references `ilk/Properties/Resources.resx` and `ilk/Properties/Resources.Designer.cs`, which are absent from the inspected repository tree. Restore the original resources or deliberately recreate compatible replacements.
5. Prepare a disposable SQL Server database with the required schema and synthetic seed records.
6. Update both connection strings in `ilk/App.config` for your SQL Server instance. Preserve the EF metadata portion of `HastaneProjeEntities`; update the provider connection settings. Review `ilk/Properties/Settings.settings` for the designer connection as well.
7. Set `ilk` as the startup project, build the solution, and run it.
8. Login requires a matching doctor, secretary, or patient test record. No seed-account installer is provided.

These steps describe prerequisites, not a verified one-command installation. The Windows application and database were not built or run during this documentation update.

## Limitations and Follow-up Work

- Passwords are assigned and compared directly in the source without password hashing. Do not use real credentials or real patient data.
- Authorization needs review beyond disabled buttons and filtered lists. For example, the patient branch in the appointment list does not explicitly disable deletion, and the deletion handler does not perform a role/ownership check.
- Appointment date and time are stored as strings in the mapped entities; the inspected save handler does not check scheduling conflicts.
- Several handlers assume a selected row or an existing database record and lack defensive validation.
- Database contexts are instantiated in forms without consistent disposal.
- The repository includes generated build outputs, Visual Studio workspace files, and restored packages. Repository cleanup is a separate follow-up; none were removed in this documentation change.
- No automated test project or CI workflow was found.

### SQL Snippet Notes

- `SQLQuery1.sql` references `DoktorAd`, whereas the current application uses `DoktorAdSoyad`; review it before execution.
- `SQLQuery2.sql` uses `ALTER TRIGGER`, so it assumes the trigger already exists. Its scalar handling of `inserted` is not suitable for multi-row inserts.
- `aa.sql` contains a placeholder `TRUNCATE TABLE` example. It is not a setup script; do not substitute a real table and run it on important data.

## Türkçe

### Proje Hakkında

Hasta, doktor, randevu, şikâyet, teşhis ve randevuya bağlı ilaç kayıtlarını yönetmek için geliştirilmiş C# Windows Forms masaüstü uygulamasıdır.

.NET Framework 4.7.2, Entity Framework 6.5.1, Database First (EDMX), LINQ ve SQL Server kullanır. Web uygulaması değildir; EF Core veya ASP.NET Core kullanmaz.

### Özellikler

- Doktor, sekreter ve hasta kayıtları üzerinden giriş kontrolü.
- Kullanıcı türüne göre değişen ekranlar ve randevu filtreleri.
- Doktor listeleme, ekleme, güncelleme, branş ve çalışma durumu seçimi.
- Hasta listeleme, ekleme, güncelleme ve silme.
- Randevu listeleme, ekleme, güncelleme ve silme.
- Randevulara şikâyet ve teşhis bilgisi kaydetme.
- Randevulara ilaç ekleme ve ilişkili ilaç kayıtlarını görüntüleme.

### Kurulum Ön Koşulları

1. Windows üzerinde Visual Studio, **.NET masaüstü geliştirme** iş yükü ve .NET Framework 4.7.2 hedefleme/geliştirici paketini hazırlayın.
2. Depoyu klonlayıp `ilk.sln` dosyasını açın; NuGet paketlerini geri yükleyin.
3. Projede referans verilen ancak depoda bulunmayan `Properties/Resources.resx` ve `Properties/Resources.Designer.cs` dosyalarını özgün projeden geri getirin veya uyumlu şekilde yeniden oluşturun.
4. SQL Server üzerinde modele uygun tabloları, ilişkileri ve görünümleri içeren bir deneme veritabanı hazırlayın. **Depoda tam veritabanı kurulum betiği veya yedeği yoktur.**
5. `ilk/App.config` içindeki iki bağlantı dizesini kendi sunucunuza göre düzenleyin. EF bağlantısındaki metadata kısmını koruyun. Tasarımcı bağlantısı için `Properties/Settings.settings` dosyasını da kontrol edin.
6. `ilk` projesini başlangıç projesi yaparak derleyin ve çalıştırın. Giriş için veritabanında uygun bir deneme kullanıcı kaydı bulunmalıdır.

### Mevcut Durum

Bu bir eğitim projesidir; gerçek hasta verileri veya gerçek parolalarla kullanılmamalıdır. Parolalar kodda hash uygulanmadan kaydedilip karşılaştırılmaktadır. Yetki kontrolleri, randevu çakışma kontrolü, hata yönetimi ve kayıt doğrulamaları geliştirilmelidir.

Kök dizindeki SQL dosyaları tam kurulum sağlamaz. Özellikle `aa.sql` veri silmeye yönelik bir örnektir; önemli veriler üzerinde çalıştırılmamalıdır.

Bu güncellemede yalnızca README eklenmiştir. Kodlar değiştirilmemiş, dosyalar silinmemiş, uygulama ve veritabanı çalıştırılarak test edilmemiştir.
