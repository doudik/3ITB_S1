using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Musicians
{
    internal sealed class Producent
    {
        static Producent producent { get; set; } = new Producent("Karel");
        public List<Slovo> slova = new List<Slovo>();
        public List<Slovo> pisnicka = new List<Slovo>();

        string nahodnaSlova = " nekamufluje, rozvádějící, operátorskému, porážena, neupevněni, nadýchal, využívajících, vyšitém, sívání, klokotávání, proměňujícího, nepořizovaly, škubajícími, zbohatlou, reptalo, osobujete, odchytilo, sémoglyf, odšroubujte, bombarduj, trojbodovém, topivům, podšálek, nejmasívnějšímu, zatrhnutou, scestovalém, seminářský, nezmodifikovaly, změřily, pařicí, reptají, teleologie, vynes, základnách, naláhvovaný, nořeného, nejspornějších, nadehvězdném, neregistrujícímu, auditovat, arších, balkanistům, cídíš, kůře, vyleptávané, převozných, prokopnutý, zásobníky, hlásého, soukenictvím, minigolfový, živnostníka, nejnevyužívanějšímu, ovíjím, polodenní, krajinněekologický, nevzrušili, naleptanému, hlenovému, nějakých, skřínkovýma, nauka, vlivnou, hlohovským, izovalerinového, proklubávanými, podinvestovaných, vyzrávající, okrouhlými, krámků, prodebatovaných, rypsovým, roztržka, neodvykla, opravňovanýma, neprovdých, nejvydatnějšího, improvizujete, paterá, delegátské, mléčnými, synonyma, uzlového, trinidadského, ochočení, vytmeleném, žiletkový, nezplatilo, cechového, útkou, statisícový, syčivých, proplakávaném, průlezovou, lymfocytický, nenecháváte, zkompletujme, podpadku, mezerovanýma, pórkovou, svíraná, objektového, víceatomovýma, expertního, vzrůstem, dokladujou, sněmovému, nevyberte, svislému, předvídavější, tesávaný, aliasy, stylizovalo, sakrální, kýčařskou, zkazím, dotknutelní, prst, rumpálový, revokacemi, lukostřelcem, genealogickému, zaznamenávají, naimpregnovanému, pokrývek, vysazených, setby, zaškrabaných, podchyceny, ukořištěnými, nymfomanky, smyčcům, neodpíráme, okoukali, nepřeměřit, nepřepsaly, sesmýkl, ochutila, dvoumiliardovými, hrůzné, nevědomost, promarňovanýma, rotorech, propřednášenými, zaclánějící, stvrď, bláznilo, zavřeštěného, plukovýma, trojslabičnýma, nekamufluje, rozvádějící, operátorskému, porážena, neupevněni, nadýchal, využívajících, vyšitém, sívání, klokotávání, proměňujícího, nepořizovaly, škubajícími, zbohatlou, reptalo, osobujete, odchytilo, sémoglyf, odšroubujte, bombarduj, trojbodovém, topivům, podšálek, nejmasívnějšímu, zatrhnutou, scestovalém, seminářský, nezmodifikovaly, změřily, pařicí, reptají, teleologie, vynes, základnách, naláhvovaný, nořeného, nejspornějších, nadehvězdném, neregistrujícímu, auditovat, arších, balkanistům, cídíš, kůře, vyleptávané, převozných, prokopnutý, zásobníky, hlásého, soukenictvím, ským, pentatonickému, nesedávala, nemlsé, okouzlované, nevyskytuju, potřebovaný, profituj, kojenců, klihovatých, neodebírajících, enginy, pokosit, neplakalo, dortík, nevykopeme, sebevrahova, nejsvéráznější, obtloukanému, nahlašovat, číší, hrnčířem, slovo, klaunka, sebevrahovi, ztlumenýma, silikátového, rakovnicka, fragmentů, přerastrovaných, studovávavaných, vystružují, dokumente, trmice, rekrutování, zbarveny, rozpařených, prosycených, vyvolencům, předbrousit, nevyskladníme, janusového, prokrmený, nevysychého, multiplexovanou, cvičeních, pohlédla, odpřednášenému, seberetou, esemesková, svíraná, objektového, víceatomovýma, expertního, vzrůstem, dokladujou, sněmovému, nevyberte, svislému, předvídavější, tesávaný, aliasy, stylizovalo, sakrální, kýčařskou, zkazím, dotknutelní, prst, rumpálový, revokacemi, lukostřelcem, genealogickému, zaznamenávají, naimpregnovanému, pokrývek, vysazených, setby, zaškrabaných, podchyceny, ukořištěnými, nymfomanky, smyčcům, neodpíráme, okoukali, nepřeměřit, nepřepsaly, sesmýkl, ochutila, dvoumiliardovými, hrůzné, nevědomost, promarňovanýma, rotorech, propřednášenými, zaclánějící, stvrď, bláznilo, zavřeštěného, plukovýma, trojslabičnýma, postel, dotěravém, tradovaly, překládají, spodničky, utrápeným, vykopu, upravovače, odzobávanému, zajměme, fondánovému, vyleštěné, zalapovávání, zúčastňují, houpávaným, státotvornými, neodměřte, nevroucími, zkoncipuje, poplácávanému, vyznamenávajícími, spojařky, bezvadných, zorávaným, rozházenýma, omítač, nepřekonatelnýma, nepodporujícímu, přetrhanější, dříkového, překonávající, síly, zrnkovému, plamínkovému, remitován, stejnosměrným, splavíte, novějšímu, zarmouceno, nejnetrpělivějších, svrhávanému, vytuhujete, dentálního, sesíláš, nenavezli, otrapou, ofotíme, vypůjčovat, zabezpečená, východofrancouzskému, ským, pentatonickému, nesedávala, nemlsé, okouzlované, nevyskytuju, potřebovaný, profituj, kojenců, klihovatých, neodebírajících, enginy, pokosit, neplakalo, dortík, nevykopeme, sebevrahova, nejsvéráznější, obtloukanému, nahlašovat, číší, hrnčířem, slovo, klaunka, sebevrahovi, ztlumenýma, silikátového, rakovnicka, fragmentů, přerastrovaných, studovávavaných, vystružují, dokumente, trmice, rekrutování, zbarveny, rozpařených, prosycených, vyvolencům, předbrousit, nevyskladníme, janusového, prokrmený, nevysychého, multiplexovanou, cvičeních, pohlédla, odpřednášenému, seberetou, esemesková, šklíbivých, neunudilo, nejdynamičtějším, nesobecky, pobíháme, developerském, namyšlenou, novotomistkou, navléknul, římanům, poutím, pročítala, himálajském, nepoškodím, pokořím, oblohy, lehla, poláků, jednosměrové, stratifikačního, konzultovaný, cítění, segmentový, ideologičnost, rozkopal, newtonově, tokového, osvětlovačův, lišákových, vysokovýkonným, sebezáchovnými, vyvážil, loknutý, spřádání, jamské, nepodražila, vyhnojenýma, zpřesněním, černomodrých, nekolkované, vypadlících, regulovat, unavitelnýma, fotoarchiv, zatmelovaných, vločkovací, nezamyslickému, souhláskami, nezazmatkovaly, teplejšího, okareckým, sokolovitém, chmýřovitými, klaustrofobik, zduří, pamětlivější, kompenzovaných, homogenizujou, označenou, etiky, neporovnatelná, kupený, posvátný, kolážovými, trojúhelnýma, zakamuflovalo, proplavány, neobesílala, nepovazováním, ukovaném, vyšťouraly, kriminalizovaných, nerevidovali, vytrvalými, šedovlasí, samotářském, otlačená, zapisovatelskému, nepřesídlete, nebrnkám, ryniofyt, neuteče, nezatahuju, vznešeně, routovitý, hydratačním, nepotrestý, vyplivování, neklíčil, zabývým, cirkulující, hadových, podborany, vdechl, vynulovaném, vanovém, stavěné, přeuzeným, odstupem, lákovém";

        public static Producent Instance
        {
            get{ return producent; }
        }

        public string name;

        private Producent(string name)
        {
            this.name = name;
            generateSlova();
        }

        void generateSlova()
        {
            string[] slovaArray = nahodnaSlova.Split(',');
            foreach (string slovo in slovaArray)
            {
                slova.Add(new Slovo(slovo));
            }
        }
        public void generateSong(int value) {
            for (int i = 0; i < value; i++)
            {
                pisnicka.Add(slova[i]);
            }
        }
        public void InfoPisnicka()
        {
            Console.WriteLine($"Producent {name} vygeneroval {pisnicka.Count} slov\n");
            foreach (var item in pisnicka)
            {
                Console.Write(item.text);
            }
        }
    }
}
