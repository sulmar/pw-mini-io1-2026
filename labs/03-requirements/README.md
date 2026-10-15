# Inżynieria Oprogramowania 1

## Laboratorium 03

### Co właściwie powinien robić system?

---

**Marcin Sulecki**
[marcin.sulecki@sulmar.pl](mailto:marcin.sulecki@sulmar.pl)

Od wizji do wymagań. Identyfikacja wymagań funkcjonalnych i niefunkcjonalnych oraz ustalenie ich priorytetów.

Szukamy niejednoznaczności i założeń ukrytych w wizji. Nadal nie projektujemy rozwiązania.

Rezultat: `docs/requirements.md`, `docs/glossary.md`.

---

Wymagania i słownik odpowiadają na jedno pytanie: **co system ma robić i co znaczą słowa, którymi to opisujemy**.

### Co umieścić

- **Wyjdź od wizji.** Każde wymaganie wynika z problemu albo z możliwości opisanej wcześniej. Nowy pomysł dopisz tylko wtedy, gdy bez niego problem zostaje nierozwiązany.
- **Opisz zachowanie, które da się sprawdzić.** Jedno wymaganie, jedno zachowanie. Po przeczytaniu powinno być jasne, czy system to robi, czy nie.
- **Oddziel funkcjonalne od niefunkcjonalnych.** Funkcjonalne mówią, co system robi. Niefunkcjonalne mówią, jak dobrze i w jakich granicach — tylko te, które wynikają z tego problemu.
- **Doprecyzuj słowa-wytrychy.** „Szybko”, „łatwo”, „bezpiecznie” i „intuicyjnie” zamień na warunek, który da się ocenić.
- **Wypisz ukryte założenia.** Kto może korzystać z systemu, jakie dane już istnieją i co musi być prawdziwe, żeby opis miał sens.
- **Nadaj priorytety.** Oznacz, co jest konieczne teraz, a co może poczekać. Jeśli wszystko jest konieczne, priorytetów nie ma.
- **Zbuduj krótki słownik.** Pojęcia z wizji i wymagań, które da się zrozumieć na dwa sposoby. Jedno pojęcie, jedno znaczenie uzgodnione w zespole.

Ktoś spoza zespołu powinien po przeczytaniu tak samo ocenić, czy wymaganie jest spełnione, i wiedzieć, co znaczą słowa użyte w opisie.

### Czego unikać

- **Powtórzenia wizji.** „System pomaga studentom w...” to nadal wizja. Tu opisujemy konkretne zachowanie.
- **Projektu rozwiązania.** Baza, framework, ekrany i architektura to nie wymagania.
- **Haseł jakości bez miary.** „Nowoczesny, skalowalny i przyjazny” nie da się sprawdzić.
- **Kilku zachowań w jednym zdaniu.** Jeśli jest „oraz”, zwykle są dwa wymagania.
- **Listy wszystkiego, co kiedyś może się przydać.** Bez priorytetu taka lista nie mówi, co budować najpierw.
- **Modelu i scenariuszy.** Relacje między pojęciami to laboratorium 04, a przebieg krok po kroku to laboratorium 06. Słownik zostaje przy znaczeniu słów.

## Dobra praktyka
Po zakończeniu pracy oznaczcie aktualny stan repozytorium tagiem `requirements-v1`.

Więcej informacji: [Oznaczanie kamieni milowych projektu w Git](/docs/good-practices/git-tags.md).