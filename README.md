# 💬 Courage Chronicles: A Personal Blog Platform

**CrystalCourage** is a deeply personal blog application built to empower my partner to share her journey of resilience, vulnerability, and strength as she navigates life with mental disabilities. This platform is designed not just as a technical showcase, but as a safe space for storytelling, healing, and connection.

---

## ✨ Purpose

This project was born out of love and necessity — to give voice to the silent battles and celebrate the courage it takes to face them. It offers a secure, responsive, and user-friendly blogging experience where stories of struggle and triumph can be shared with dignity and privacy.

---

## 🛠️ Tech Stack

| Layer         | Technology Used                     |
|--------------|--------------------------------------|
| Frontend     | Angular (Responsive Design)          |
| Backend      | .NET 8 (ASP.NET Core Web API)        |
| Database     | SQL Server                           |
| Auth         | OAuth 2.0, Single Sign-On (SSO), JWT |
| ORM          | Entity Framework Core                |
| API Comm     | RESTful API calls                    |

---

## 🔐 Authentication & Security

- **OAuth 2.0** integration for secure third-party login
- **Single Sign-On (SSO)** support for seamless user experience
- **JWT Tokens** for stateless authentication and secure API access
- Role-based access control to protect sensitive content

---

## 📱 Features

- 📝 **Blog Creation & Management**: Write, edit, and publish posts with rich formatting
- 🔍 **Search & Filter**: Easily find posts by tags, dates, or keywords
- 📱 **Responsive UI**: Optimized for mobile, tablet, and desktop
- 🧠 **Mental Health Focus**: Designed with empathy and accessibility in mind
- 🛡️ **Secure API**: Built with REST principles and protected endpoints

---

## 🧩 Architecture Overview

- **Frontend**: Angular components communicate with backend via HTTP services
- **Backend**: ASP.NET Core controllers expose REST endpoints secured with JWT
- **Database**: SQL Server schema managed via Entity Framework migrations
- **Auth Flow**: OAuth provider → SSO → JWT issuance → API access

---

## 🚀 Getting Started

1. Clone the repo
2. Set up SQL Server and update connection strings
3. Configure OAuth credentials
4. Run backend: `dotnet run`
5. Run frontend: `ng serve`
6. Access the app at `http://localhost:4200`

---

## ❤️ Acknowledgments

To my Partner — your courage is the heartbeat of this project. May your words inspire others to find strength in their own stories.
