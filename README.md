# 1. mechanizm fast-forward a merge commit
  # fast-forward wystepuje, gdy galaz docelowa nie zawiera nowych commitow; git przesuwa jedynie wskaznik head. merge commit jest generowany w sytuacji wystapienia niezaleznych zmian na obu galeziach, co wymaga utworzenia wezla laczacego historie.

   # 2. merge vs rebase
   # merge zachowuje pelna chronologie zdarzen wraz z commitami laczacymi. rebase umozliwia zachowanie liniowej struktury historii poprzez przeniesienie commitow na wierzch galezi docelowej. metoda rebase nie jest zalecana dla galazi wspoldzielonych.

#  3. rozwiazanie konfliktu
#  konflikt w pliku program.cs wywolany zostal rownoczesna modyfikacja tych samych linii kodu. rozwiazanie polegalo na manualnej integracji obu wersji komunikatow oraz usunieciu markerow konfliktu. integralnosc kodu zostala zachowana.