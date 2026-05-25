# Svar

Alla LED:s alltid skall ha egen strömförsörjning med eget motstånd på 220-330 Ω mot hög (5V) och jord (GND).

- Seriekoppling funkar inte: en LED genererar ett överskott av energi, och de andra knappt något. Varje motstånd skall ha c:a 1.9-2.2 V:s spänning och 3*1.9 = 5.7 V, vilket är mer än vad Arduinon kan ge.
- Parallellkoppling är inte heller någon bra idé: olikheter vid tillverkningen får en LED att ta över all ström från de andra motstånden, så bara en lyser. 