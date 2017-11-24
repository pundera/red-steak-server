﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedSteakServer.Data.Import
{
    public static class JsonImportHolder
    {
        public static string Questions = @"[
          {
            'id': 1,
            'number': 1,
            'header': 'Věk?',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 20,
            'orderNumber': 1
          },
          {
            'id': 2,
            'number': 2,
            'header': 'Jste?',
            'type': 2,
            'typeValues': ['Muž', 'Žena'],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 2
          },
          {
            'id': 3,
            'number': 3,
            'header': 'Jaký je Váš rodinný stav?',
            'type': 2,
            'typeValues': [
              'Svobodný/á',
              'Nesezdané soužití',
              'Ženatý, vdaná',
              'Rozvedený/á',
              'Vdovec/a'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 3
          },
          {
            'id': 4,
            'number': 4,
            'header': 'Kolik máte vlastních (biologických) dětí?',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 4
          },
          {
            'id': 5,
            'number': 5,
            'header': 'Kolik máte sourozenců? (Mužského pohlaví)',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 5
          },
          {
            'id': 6,
            'number': 5,
            'header': 'Kolik máte sourozenců? (Ženského pohlaví)',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 6
          },
          {
            'id': 7,
            'number': 5,
            'header': 'Kolik máte sourozenců? (Nevím/Vím)',
            'type': 2,
            'typeValues': [
              'Nevím',
              'Vím'
            ],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 7
          },
          {
            'id': 8,
            'number': 6,
            'header': 'Jaké je Vaše nejvyšší ukončené školní vzdělání?',
            'type': 2,
            'typeValues': [
              'Neuk. zákl.',
              'Základní',
              'Prakt. šk.',
              'Vyuč. bez mat.',
              'S. bez mat.',
              'S. odb. s mat.',
              'S. všeob. s mat.',
              'Pokr. nást. st.',
              'Vyš. odb.',
              'VŠ'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 8
          },
          {
            'id': 9,
            'number': 7,
            'header': 'V jakém kraji jste se narodil?',
            'type': 2,
            'typeValues': [
              'Karl.',
              'Úst.',
              'Lib.',
              'Plz.',
              'Jih. č.',
              'Stř.',
              'Praha',
              'Vys.',
              'Král.',
              'Pard.',
              'Jih. m.',
              'Olom.',
              'Zlín.',
              'Mor. sl.'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 9
          },
          {
            'id': 10,
            'number': 8,
            'header': 'Pracujete v současné době někde?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 10
          },
          {
            'id': 11,
            'number': 9,
            'header': 'Pokud ano, jakou práci vykonáváte?',
            'type': 1,
            'typeValues': [],
            'vertical': false,
            'defaultValue': null,
            'orderNumber': 11
          },
          {
            'id': 12,
            'number': 10,
            'header': 'Jakou má tato pracovní činnost formu?',
            'type': 2,
            'typeValues': [
              'Bez jakékoliv pracovní smlouvy',
              'Brigádně (Nový prostor včetně)',
              'Trvalý pracovní poměr na dobu určitou',
              'Trvalý pracovní poměr na dobu neurčitou',
              'Dohoda o pracovní činnosti',
              'Dohoda o provedení práce',
              'Na živnostenský list',
              'Nevím'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 12
          },
          {
            'id': 13,
            'number': 11,
            'header': 'Jestliže jste nezaměstnaný(á), jste v evidenci Úřadu práce?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 13
          },
          {
            'id': 14,
            'number': 12,
            'header': 'Pobíráte v současné době pravidelně nějaké sociální dávky?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 14
          },
          {
            'id': 15,
            'number': 13,
            'header': 'Pokud ano, o jaký typ sociální dávky se jedná?',
            'type': 2,
            'typeValues': [
              'Dávky v nezaměstnanosti',
              'Nemocenské pojištění (vč. „mateřské“)',
              'Dávky státní sociální podpory*',
              'Dávky důchodového pojištění',
              'Dávky sociální pomoci**',
              'Doplatek do částky životního minima'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 15
          },
          {
            'id': 16,
            'number': 14,
            'header': 'Pobíráte v současné době nějaký důchod?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 16
          },
          {
            'id': 17,
            'number': 15,
            'header': 'Jaký je Váš současný celkový čistý měsíční příjem?',
            'type': 2,
            'typeValues': [
              'Do 5000 Kč',
              '5001 – 6 999 Kč',
              '7000 – 8 999 Kč',
              '9000 – 11 999 Kč',
              '12 000 Kč a více'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 17
          },
          {
            'id': 18,
            'number': 16,
            'header': 'V jaké rodině jste převážně vyrůstal(a)?',
            'type': 2,
            'typeValues': [
              'V úplné rodině, s oběma rodiči',
              'V neúplné rodině, pouze s jedním rodičem',
              'V rodině příbuzných (u babičky, tety, strýce apod.)',
              'V adoptivní rodině',
              'V pěstounské péči',
              'Neměl(a) jsem rodinu (v ústavní péči)'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 18
          },
          {
            'id': 19,
            'number': 17,
            'header': 'Strávil(a) jste část nebo celé dětství v dětském domově?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 19
          },
          {
            'id': 20,
            'number': 18,
            'header': 'Pokud ano, jak dlouho? (dětský domov)',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 20
          },
          {
            'id': 21,
            'number': 19,
            'header': 'Byl(a) jste někdy v dětství v jiném zařízení (diagnostický ústav, výchovný ústav)?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 21
          },
          {
            'id': 22,
            'number': 20,
            'header': 'Pokud ano, jak dlouho? (diagnostický ústav, výchovný ústav)',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 22
          },
          {
            'id': 23,
            'number': 20,
            'header': 'Kde? (diagnostický ústav, výchovný ústav)',
            'type': 1,
            'typeValues': [],
            'vertical': false,
            'defaultValue': null,
            'orderNumber': 23
          },
          {
            'id': 24,
            'number': 21,
            'header': 'Byl(a) jste někdy ve vězení?',
            'type': 3,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 24
          },
          {
            'id': 25,
            'number': 22,
            'header': 'Pokud ano, jak celkově dlouho? (vězení)',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 25
          },
          {
            'id': 26,
            'number': 23,
            'header': 'Jaká je Vaše sexuální orientace?',
            'type': 2,
            'typeValues': [
              'Heterosexuální',
              'Bisexuální',
              'Homosexuální'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 26
          },
          {
            'id': 27,
            'number': 24,
            'header': 'Jak dlouho žijete bez domova?',
            'type': 0,
            'typeValues': [],
            'vertical': false,
            'defaultValue': 0,
            'orderNumber': 27
          },
          {
            'id': 28,
            'number': 25,
            'header': 'Co bylo podle Vás hlavní příčinou toho, že jste se ocitl(a) bez domova? Uveďte pouze 1 příčinu.',
            'type': 2,
            'typeValues': [
              'Ovdovění',
              'Rozvod, rozpad vztahu',
              'Propuštění z vězení',
              'Odchod z ústavní výchovy',
              'Ztráta zaměstnání',
              'Dluhy',
              'Alkohol, drogy, gamblerství',
              'Nemoc',
              'Ztráta bytu',
              'Vlastní rozhodnutí'
            ],
            'vertical': true,
            'defaultValue': 0,
            'orderNumber': 28
          }
        ]";
    }
}