# Inżynieria Oprogramowania 1

## Roadmap kursu

Celem kursu jest przejście od **pomysłu i problemu** do **działającego systemu**, który potrafimy zrozumieć, rozwijać i zmieniać.

Generatywna AI pozwala szybko tworzyć kod. Nie rozwiązuje jednak za nas najważniejszego problemu: **skąd wiemy, co właściwie należy zbudować?**

W kolejnych laboratoriach będziemy rozwijać własne projekty i stopniowo tworzyć ich specyfikację, model oraz architekturę.

---

### Laboratorium 01 — Wprowadzenie

**Skąd wiemy, co właściwie mamy zbudować?**

Na przykładzie [Campus AI Assistant](https://github.com/sulmar/campus-ai-assistant) zobaczymy, jak szybko agent AI może wygenerować działającą aplikację na podstawie kilku zdań.

Sprawdzimy również, ile decyzji agent musiał podjąć za nas, ponieważ nie zostały określone w opisie systemu.

**Rezultat:** potrzeba doprecyzowania wizji systemu.

---

### Laboratorium 02 — Wizja projektu

**Jaki problem chcecie rozwiązać?**

Zespoły przedstawiają własne pomysły na projekty. Określamy problem, użytkowników oraz najważniejsze możliwości przyszłego systemu.

Nie projektujemy jeszcze rozwiązania.

**Rezultat:** `docs/vision.md`

---

### Laboratorium 03 — Wymagania

**Co właściwie powinien robić system?**

Szukamy niejednoznaczności i założeń ukrytych w wizji projektu. Doprecyzowujemy oczekiwane zachowanie systemu oraz tworzymy wspólny język projektu.

**Rezultat:**

- `docs/requirements.md`
- `docs/glossary.md`

---

### Laboratorium 04 — Przypadki użycia

**Kto i po co korzysta z systemu?**

Identyfikujemy aktorów, ich cele oraz scenariusze wykorzystania systemu.

Wykorzystujemy diagram przypadków użycia UML do przedstawienia systemu z perspektywy jego użytkowników.

**Rezultat:** `docs/use-cases/`

---

### Laboratorium 05 — Model domeny

**O jakich pojęciach mówimy?**

Identyfikujemy najważniejsze pojęcia występujące w problemie oraz związki między nimi.

Wprowadzamy UML jako sposób zapisania i komunikowania modelu domeny.

**Rezultat:** `docs/domain.md`

---

### Laboratorium 06 — Kontekst systemu

**Gdzie kończy się nasz system?**

Ustalamy granicę projektowanego systemu. Identyfikujemy użytkowników oraz systemy zewnętrzne, z którymi nasze rozwiązanie współpracuje.

**Rezultat:** `docs/system-context.md`

---

### Laboratorium 07 — Architektura

**Jak podzielić system na części?**

Przechodzimy od opisu problemu do projektu rozwiązania. Określamy odpowiedzialności poszczególnych elementów systemu oraz zależności między nimi.

**Rezultat:** `docs/architecture/`

---

### Laboratorium 08 — Decyzje

**Dlaczego zrobiliśmy to właśnie tak?**

W trakcie projektowania podejmujemy decyzje, których przyczyny z czasem przestają być oczywiste.

Poznajemy Architecture Decision Records (ADR) jako prosty sposób zachowania kontekstu najważniejszych decyzji.

**Rezultat:** `docs/decisions/`

---

### Laboratorium 09 — Zmiana

**Co się stanie, gdy zmienią się wymagania?**

Projekt otrzymuje nowe wymagania. Analizujemy ich wpływ na model domeny, przypadki użycia, architekturę oraz implementację.

Sprawdzamy, czy wcześniejsze decyzje pomagają nam rozwijać system, czy utrudniają jego zmianę.

**Rezultat:** zaktualizowana specyfikacja, architektura, testy i implementacja.

---

### Laboratorium 10 — Prezentacja projektu

**Czy potrafimy uzasadnić nasze rozwiązanie?**

Zespoły prezentują nie tylko końcową specyfikację projektu, ale przede wszystkim drogę, która doprowadziła od problemu do rozwiązania.

Prezentacja powinna pokazać ścieżkę:

**problem → wizja → wymagania → przypadki użycia → model → architektura → decyzje → implementacja → zmiany**

---

## Dokąd zmierzamy?

W trakcie kursu repozytorium projektu będzie rozwijało się razem z naszym rozumieniem problemu:

    project/
    ├── docs/
    │   ├── vision.md
    │   ├── glossary.md
    │   ├── requirements.md
    │   ├── use-cases/
    │   ├── domain.md
    │   ├── system-context.md
    │   ├── architecture/
    │   └── decisions/
    ├── src/
    └── tests/

Nie tworzymy dokumentacji dla samej dokumentacji.

Każdy artefakt powinien pomagać odpowiedzieć na konkretne pytanie dotyczące tworzonego systemu.

**Od problemu do kodu — i od kodu do systemu, który potrafimy zmieniać.**
