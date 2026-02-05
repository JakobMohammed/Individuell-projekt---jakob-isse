# CI/CD – Individuellt projekt

## Beskrivning
Detta projekt är en del av kursen CI/CD. Syftet med uppgiften är att visa grundläggande förståelse för versionshantering, Continuous Integration (CI) och automatisering av build-processen.

Projektet består av ett enkelt C# Web API som kan köras lokalt och testas via Swagger.

---

## Teknisk översikt
- Språk: C#
- Ramverk: .NET Web API
- Versionshantering: Git & GitHub
- CI: GitHub Actions

---

## Vad som är genomfört

### Versionshantering
- Projektet är versionshanterat med Git
- Källkoden finns publicerad i ett publikt GitHub-repository
- Commit-historik visar löpande arbete i projektet

### Continuous Integration (CI)
- En CI-pipeline är skapad med GitHub Actions
- Pipen körs automatiskt vid push till `main`
- CI-flödet innehåller:
  - Checkout av kod
  - Setup av .NET
  - Restore av dependencies
  - Build av projektet
  - Publish-steg
  - Upload av build-artifact

CI-pipelinen körs utan fel och verifierar att projektet går att bygga automatiskt.

---

## Continuous Deployment (CD)
Jag har försökt deploya applikationen till AWS Elastic Beanstalk, men stött på problem i deploy-steget trots felsökning.

Som alternativ lösning har jag implementerat ett förenklat CD-steg där applikationen automatiskt byggs och publiceras som artifact via GitHub Actions. Detta visar att deploy-processen kan automatiseras, även om den inte är kopplad till en extern molnplattform.

---

## Problem som uppstod och hur de hanterades
- Problem med AWS Elastic Beanstalk-deployment
- Svårigheter med zip-struktur och permissions
- Git-relaterade problem (t.ex. .vs-mapp och rätt .gitignore)

Lösningar:
- Införande av korrekt `.gitignore`
- Felsökning via GitHub Actions logs
- Förenklad CD-lösning via artifacts

---

## Slutsats
Projektet visar grundläggande förståelse för CI/CD-koncept:
- Automatisk build via CI
- Versionshantering
- Grundläggande deploy-automatisering

Fokus har legat på att få ett fungerande och tydligt CI-flöde snarare än en avancerad produktionsdeployment.
