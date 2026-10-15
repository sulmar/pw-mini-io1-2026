# Oznaczanie kamieni milowych projektu w Git

W trakcie pracy nad projektem wizja, wymagania i architektura systemu będą się zmieniać.

Warto oznaczać ważne etapy projektu za pomocą **tagów Git**, aby móc wrócić do wcześniejszego stanu dokumentacji i prześledzić jej ewolucję.

Przykładowe tagi:

* **vision-v1** — pierwsza wersja wizji projektu.
* **requirements-v1** — pierwsza wersja słownika domenowego i wymagań.
* **architecture-v1** — pierwsza wersja architektury.
* **mvp-v1** — pierwsza działająca wersja aplikacji.

## Jak utworzyć tag?

Oznaczenie aktualnego commita:
```bash
git tag -a requirements-v1 -m "Pierwsza wersja wymagań"
git push origin requirements-v1
```

Oznaczenie wcześniejszego commita:
```bash
git tag -a vision-v1 <commit-sha> -m "Pierwsza wersja wizji"
git push origin vision-v1
```

## Commit a tag

* **Commit** zapisuje konkretną zmianę w projekcie.
* **Tag** oznacza ważny punkt w historii projektu.

**Tag nie oznacza, że dokumentacja jest ostateczna. Oznacza stan wiedzy zespołu na określonym etapie projektu.**