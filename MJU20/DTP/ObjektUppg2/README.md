# ObjektUppg2
Objekt-uppgifter 2:

1. Skapa en klass dictEntry som innehåller
   attributen 
   
      string swedish, english;

   Lägg upp en array av dictEntry:s, som innehåller
   t.ex.
   
        head    huvud
        see     se
        father  far, pappa
        tree    träd
        moon    måne
        move    flytta
        city    stad
        
   Skriv kod som skriver ut denna array av dictEntry:s
   t.ex. så här:

        english   swedish
        -------------------
        head      huvud
        see       se
        father    far, pappa
        tree      träd
        moon      måne
        move      flytta
        city      stad
        -------------------

2. Gör samma sak, men byt ut arrayer mot Listor. Använd
   Add för att lägga upp dictEntry:s i Listan, i stället
   för att använda en initierare.
   
3. Gör om programmet så att det läser in en fil som
   innehåller rader
   
        head#huvud
        see#se
        father#far, pappa
        tree#träd
        moon#måne
        move#flytta
        city#stad

   som du splittar och lägger upp i listan av dictEntry:s.

4. Skapa en while-loop så att du kan bygga ett kommando-
   system liknande som t.ex. den latin-svenska ordlistan.
   
5. Skapa ett lägg-in-kommando, där du kan lägga in
   dictEntry:s i ordlistan.
   
6. Skapa ett sparakommando, så att du kan spara ordlistan.

7. Skapa ett ta-bort-kommando så att du kan ta bort
   felaktiga dictEntry:s.

8. Skapa ett kommando som slumpar fram ett dictEntry,
   skriver ut det engelska ordet, och frågar efter svensk
   översättning. Du får då mata in översättning, och om
   det var rätt, så skriver programmet att det var rätt,
   annars skriver den att det var fel, och skriver ut
   rätt översättning, t.ex. så här:
   
       > test
       Vad är 'move' på svenska? måne
       Tyvärr fel! 'move' är 'flytta' på svenska.
