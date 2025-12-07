:

🎬 Serenity Movie Tutorial Project

This project is created by following the Serenity Movie Tutorial to understand modules, forms, grids, dialogs, master–detail relations, and image upload features in the Serenity Framework.

📌 Project Overview

This application contains two main modules:

🎞️ Movie Module

Add / Edit / Delete Movies

Genre selection

Movie cast management

Storyline, duration, release date fields

Master–detail: Movie → CastList

🧑 Person Module

Add / Edit / Delete Person records

Personal details (Name, Gender, Birthdate, Birthplace)

List of movies acted in (Loaded using PersonMovieGrid)

🧩 Master–Detail Setup

Implemented using MasterDetailRelation

Auto-handles Save, Retrieve, Delete

CastList loads inside Movie dialog

Person dialog shows movies acted by the person

🖼️ Image Uploads

Primary image upload

Gallery image upload (multiple images)

Custom folder structure using FilenameFormat

🛠️ Technologies Used

ASP.NET Core

Serenity Framework

TypeScript

SQL Server

FluentMigrator

Visual Studio 2019
