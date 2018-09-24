using System;

class TP1_NP0_VersionEtud {

    const int nombreDeJoursDansUneAnnéeNormale = 365;
    const int nombreDeJoursDansUneAnnéeBissextile = 366;
    const int codeASCIIespace = 32;
    const int codeASCII0 = 48;
    const int codeASCII9 = 57;
    const int maxDeJoursDansUnMois = 31;
    const int indiceFévrier = 2;
    const int févrierNormal = 28;
    const int févrierBissextil = 29;
    const int codeDErreurChaîneDateTropCourte = 1;
    const int codeDErreurJourDateIncorrect = 2;
    const int codeDErreurMoisDateIncorrect = 3;
    const int codeDErreurAnnéeDateIncorrecte = 4;
    const int codeDErreurDateNAPasDeSens = 5;
    //VOUS AUREZ À AJOUTER 6 CONSTANTES!

    static bool EstBissextile(int uneAnnée) {
        //CODÉE POUR VOUS! Une version encore plus simplifée de ce que nous avons fait en classe
        return uneAnnée % ((uneAnnée % 100 == 0) ? 400 : 4) == 0; 
    }

    static int NombreDeJoursDAnnéesComplètesEntre2Années(int annéeMin, int annéeMax) {
        int compte = 0;
        //PRÉ-CONDITION: annéeMax est donc forcément plus grande que annéeMin
        for(int min = annéeMin; min < annéeMax; min++) {
            if (EstBissextile(min)) {
                compte += 366;
            }
            else {
                compte += 365;
            }
        }
        
        return compte; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }
     
    static bool EstMoisDe30Jours(int indiceMois) {
        bool trenteJoursBool;
            switch (indiceMois) {
            case 4:
                trenteJoursBool = true;
                break;
            case 6:
                trenteJoursBool = true;
                break;
            case 9:
                trenteJoursBool = true;
                break;
            case 11:
                trenteJoursBool = true;
                break;
            default:
                trenteJoursBool = false;
                break;
        }

        return trenteJoursBool; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int NombreDeJoursDansMois(int indiceDuMois, bool annéeBissextile) {
        int nbJoursMois;
        if (indiceDuMois == 2) {
            if (annéeBissextile) {
                nbJoursMois = 29;
            }
            else {
                nbJoursMois = 28;
            }
        }
        else if (EstMoisDe30Jours(indiceDuMois)) {
            nbJoursMois = 30;
        }
        else {
            nbJoursMois = 31;
        }
        return nbJoursMois; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int NombreDeJoursDeMoisCompletsEntre2Mois(int indiceMois1, int indiceMois2, bool annéeEstBissextile) {
        //PRÉ-CONDITION: indiceMois2 est donc forcément plus grand que indiceMois1
        int compte = 0;
        for (int min = indiceMois1; min < indiceMois2; min++) {
            compte += NombreDeJoursDansMois(min, annéeEstBissextile);
        }
        return compte; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int NombreDeJoursDeMoisCompletsDIciLaFinDeLAnnée(int indice_Mois, bool uneAnnéeBissextile) {
        //MÉTHODE QUE VOUS DEVEZ CODER!!!

        return 0; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int NombreJoursDeMoisCompletsDepuisDébutDeLAnnée(int indiceMensuel, bool année_Bissextile) {
        //MÉTHODE QUE VOUS DEVEZ CODER!!!

        return 0; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int NombreDeJoursDIciLaFinDuMois(int dateDeJour, int indiceMois, bool annéeBissextile) {
        //MÉTHODE QUE VOUS DEVEZ CODER!!!

        return 0; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int NombreDeJoursEntreDeuxDates(int jour1, int mois1, int année1, int jour2, int mois2, int année2) {
        //PRÉ-CONDITION: la "date 2" ne peut être inférieure à la "date 1"

        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return 0; //POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static bool ValiderLongueurChaîne(string dateInscriteParUsager) {
        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return true;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static bool CaractèreEstChiffreValide(char carac, bool zéroPermis) {
        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return true;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int ConvertirCaractèreEnNombre(char carac) {
        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return 0;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int ExtraireJourDUneDate(string uneDateInscriteParUsager) {
        //PRÉ-CONDITION: la longueur de la chaîne est suffisante pour que la date soit valide
        //Si la valeur retournée est -1, cela veut dire que le jour de la date est incorrect (ex.: le 33 d'une certain mois)

        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return 0;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int ExtraireIndiceMoisDUneDate(string laDateInscriteParUsager) {
        //Si la valeur retournée est -1, cela veut dire qu'aucun mois valide n'a été trouvé dans la chaîne inscrite par l'usager

        //MÉTHODE QUE VOUS DEVEZ CODER!!!
         return 0;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static int ExtraireAnnéeDUneDate(string dateInscriteParLUsager) {
        //PRÉ-CONDITION: la longueur de la chaîne est suffisante pour que la date soit valide
        //Si la valeur retournée est -1, cela veut dire que la fin de la chaîne inscrite par l'usager n'est pas une année valide

        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return 0;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static bool ValiderCohérenceInterneDUneDate(int jour, int indiceMois, int année) {

        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return true;//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    static string MessageDErreurApproprié(int codeDErreur, string quantieme) {

        //MÉTHODE QUE VOUS DEVEZ CODER!!!
        return "";//POUR QUE LE COMPILATEUR SOIT CONTENT!
    }

    /*À PARTIR D'ICI, AVANT LE MAIN, VOUS AUREZ DONC TROIS MÉTHODES À CODER AU COMPLET!*/

    static void Main() {
        //NE TOUCHEZ À RIEN À PARTIR D'ICI... SAUF POUR LA TOUTE FIN DU MAIN!!!
        string chaîneDate1, chaîneDate2;
        int jourDate1, moisDate1, annéeDate1, jourDate2, moisDate2, annéeDate2;
        jourDate1 = moisDate1 = annéeDate1 = jourDate2 = moisDate2 = annéeDate2 = 0; //Mettre une valeur initiale BIDON pour que le compilateur soit content!

        Console.WriteLine("BIENVENUE AU CALCULATEUR TEMPOREL!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Veuillez inscrire votre première date, svp.: ");
        string messageDErreur;
        do {
            messageDErreur = "";//Réinitialisation
            chaîneDate1 = Console.ReadLine();

            if (!ValiderLongueurChaîne(chaîneDate1))
                messageDErreur = MessageDErreurApproprié(codeDErreurChaîneDateTropCourte,"première");

            if (messageDErreur.Length == 0) {
                jourDate1 = ExtraireJourDUneDate(chaîneDate1);
                if (jourDate1 == -1)
                    messageDErreur = MessageDErreurApproprié(codeDErreurJourDateIncorrect, "première");
            }

            if (messageDErreur.Length == 0) {
                moisDate1 = ExtraireIndiceMoisDUneDate(chaîneDate1);
                if (moisDate1 == -1)
                    messageDErreur = MessageDErreurApproprié(codeDErreurMoisDateIncorrect, "première");
            }

            if (messageDErreur.Length == 0) {
                annéeDate1 = ExtraireAnnéeDUneDate(chaîneDate1);
                if (annéeDate1 == -1)
                    messageDErreur = MessageDErreurApproprié(codeDErreurAnnéeDateIncorrecte, "première");
            }

            if ((messageDErreur.Length == 0) && (!ValiderCohérenceInterneDUneDate(jourDate1,moisDate1,annéeDate1)))
                messageDErreur = MessageDErreurApproprié(codeDErreurDateNAPasDeSens, "première");

            if (messageDErreur.Length != 0) {
                Console.WriteLine(messageDErreur);
                Console.WriteLine();
                Console.WriteLine("Il faut réinscrire la première date");
            }
        } while (messageDErreur.Length != 0);

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Maintenant, il faut inscrire une seconde date: ");
        do {
            messageDErreur = "";//Réinitialisation
            chaîneDate2 = Console.ReadLine();

            if (!ValiderLongueurChaîne(chaîneDate2))
                messageDErreur = MessageDErreurApproprié(codeDErreurChaîneDateTropCourte, "deuxième");

            if (messageDErreur.Length == 0) {
                jourDate2 = ExtraireJourDUneDate(chaîneDate2);
                if (jourDate2 == -1)
                    messageDErreur = MessageDErreurApproprié(codeDErreurJourDateIncorrect, "deuxième");
            }

            if (messageDErreur.Length == 0) {
                moisDate2 = ExtraireIndiceMoisDUneDate(chaîneDate2);
                if (moisDate2 == -1)
                    messageDErreur = MessageDErreurApproprié(codeDErreurMoisDateIncorrect, "deuxième");
            }

            if (messageDErreur.Length == 0) {
                annéeDate2 = ExtraireAnnéeDUneDate(chaîneDate2);
                if (annéeDate2 == -1)
                    messageDErreur = MessageDErreurApproprié(codeDErreurAnnéeDateIncorrecte, "deuxième");
            }

            if ((messageDErreur.Length == 0) && (!ValiderCohérenceInterneDUneDate(jourDate2, moisDate2, annéeDate2)))
                messageDErreur = MessageDErreurApproprié(codeDErreurDateNAPasDeSens, "deuxième");

            if (messageDErreur.Length != 0) {
                Console.WriteLine(messageDErreur);
                Console.WriteLine();
                Console.WriteLine("Il faut réinscrire la deuxième date");
            }
        } while (messageDErreur.Length != 0);

        bool retourDansLePassé;

        if (annéeDate1 == annéeDate2) {
            if (moisDate1 == moisDate2) {
                retourDansLePassé = jourDate1 > jourDate2;
            }
            else {
                retourDansLePassé = moisDate1 > moisDate2;
            }

        }
        else {
            retourDansLePassé = annéeDate1 > annéeDate2;
        }

        if (retourDansLePassé) {
            int jourTampon = jourDate1;
            int moisTampon = moisDate1;
            int annéeTampon = annéeDate1;
            jourDate1 = jourDate2;
            moisDate1 = moisDate2;
            annéeDate1 = annéeDate2;
            jourDate2 = jourTampon;
            moisDate2 = moisTampon;
            annéeDate2 = annéeTampon;
        }

        Console.WriteLine();
        Console.WriteLine();

        int nombreDeJours = NombreDeJoursEntreDeuxDates(jourDate1,moisDate1,annéeDate1,jourDate2,moisDate2,annéeDate2);
        Console.WriteLine("RÉSULTAT: vous {0} dans le temps pour un total de {1} jour{2}",(retourDansLePassé ? "reculez" : "avancez"),nombreDeJours,(nombreDeJours < 2 ? "" : "s"));

        //C'est ici que vous ajoutez du code!

    }
}