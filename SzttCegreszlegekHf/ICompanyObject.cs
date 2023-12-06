using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
    interface ICompanyObject
    {
        string Name { get; set; }
        int EmployeeCount { get; }

        void List();
    }
    //3. CÉGRÉSZLEGEK

    //A) A Composite minta segítségével oldja meg a következőket:
    //o A részlegek hierarchiájának modellezése oszályokkal / interfészekkel.
    //o A név legyen lekérdezhető az alkalmazottakra és a részlegekre is, mindkét esetben egy string-el
    //    térjen vissza.
    //o A részlegekhez vezessen be egy műveletet alkalmazottak és alrészlegek felvételére.Egyszerre
    //lehessen akár többet is hozzáadni(paraméter egy alkalmazott, vagy részleg objektumokat tároló
    //lista). Ha az adott részlegben(amelyikhez éppen hozzá akarjuk adni az új elemeket) az új elemek
    //létszámával együtt az összlétszám meghaladná az adott részleg maximális létszámát, akkor a
    //hozzáadás legyen teljesen sikertelen, ne adja hozzá egyik kért elemet se! Fontos: a részlegek
    //nem tárolhatják el, hogy pontosan hány alkalmazottuk van, azt minden hozzáadás során ki kell
    //frissen számítani.
    //o A részlegekhez vezessen be egy műveletet adott alkalmazott vagy részleg eltávolítására is
    //(paraméter egy alkalmazott vagy részleg objektum).
    //o Írjon egy műveletet, mely egy részlegre vonatkozóan kilistázza a nevét, és az összes tartalmazott
    //alkalmazott nevét, minden alrészlegével, rekurzívan. Minden részleg/alkalmazott információ új
    //sorban jelenjen meg, minden sorban a következő két mezővel, az egyes mezők 3 darab szóközzel
    //elválasztva:
    //▪ "Dept." vagy "Empl." sztring, attól függően, hogy az adott elem részleg vagy
    //alkalmazott
    //▪ Adott alkalmazott/részleg neve
    //o A megjelenítés során elég az egyszerű lista, nem szükséges behúzással vagy egyéb módon a
    //hierarchiát vizualizálni.
    //o A megjelenítés során tesztadatokkal illusztrálja a megoldásának működőképességét.
    //Mutasson példát sikertelen hozzáadásra, és az adatok listázására is.
    //o Megoldásában nem szükséges semmilyen adatot fájlba menteni, vagy onnan betölten
}
