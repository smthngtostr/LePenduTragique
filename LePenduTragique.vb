'
' Si vous voulez jouer au jeu plus rapidement, commentez la ligne 15 et utilisez la ligne 16
'
Module Module1
    Function avoirlenombredeletredansuntrucdecaractère(letruc, laouonenest)
        laouonenest = 1 + laouonenest
        Dim rien = letruc(laouonenest)
        On Error GoTo ONREGLELESPROBLEMESNIMPORTECOMMENT
        laouonenest = avoirlenombredeletredansuntrucdecaractère(letruc, laouonenest)
        Return laouonenest
ONREGLELESPROBLEMESNIMPORTECOMMENT:
        Return 1 + laouonenest
    End Function
    Function fonctionpouraffichercequiyaenparametre(letrucàafficher, lapositionàafficher)
        If lapositionàafficher < avoirlenombredeletredansuntrucdecaractère(letrucàafficher, 0) Then
            ' If lapositionàafficher < Len(letrucàafficher) Then
            Console.Write(letrucàafficher(lapositionàafficher))
            lapositionàafficher = 1 + lapositionàafficher
            fonctionpouraffichercequiyaenparametre(letrucàafficher, lapositionàafficher)
        End If
    End Function
    Function valeurplusplus(ByRef valeur)
        valeur = 1 + valeur
    End Function
    Function imagepotanse()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("---------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavecuntète()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o   ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("---------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavecuntètesonvantreetcestbra()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o   ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   -|-", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("---------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavectoutlecorpsauflesextrémité()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o   ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   -|-", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   / \", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("---------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavectoutlecorpsauflesextrémitéaveclamaingauche()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o   ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  x-|-", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   / \", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("---------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavectoutlecorpsauflesextrémitéaveclamaingaucheetlamaindroite()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o   ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  x-|-x", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   / \", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("----------------------------------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavectoutlecorpsauflesextrémitéaveclesmainetlepiedgauche()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  x-|-x", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  _/ \", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("----------------------------------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Function imagepotanseavectoutlecorpsauflesextrémitéaveclesmainetlepiedgaucheetlepieddroit()
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  |||||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                   |||", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    |", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                    o", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  x-|-x", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  _/ \_", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("   ||||||||||||||||||||||                                                  ", 0)
        Console.WriteLine(" ")
        fonctionpouraffichercequiyaenparametre("----------------------------------------------------------------------------------------------------------------------", 0)
        Console.WriteLine(" ")
    End Function
    Sub Main()
        Dim lesvie = 7
        If False Then
FONCTIONAFFICHERLEMESSAGEQUANDONTAPERIEN:
            Console.Write("Veuillez taper un truc.")
            Console.WriteLine(" ")
            GoTo SAISIEETVERIFICATIONDELALETRESAISIE
FONCTIONAFFICHERLEMESSAGEQUANDONTAPEPASUNELETTRE:
            Console.Write("Vous avez pas tapé une lettre !")
            Console.WriteLine(" ")
            GoTo SAISIEETVERIFICATIONDELALETRESAISIE
FONCTIONSIONADEJATAPELALETRE:
            Console.Write("Vous avez déjà tapé cette lettre !")
            Console.WriteLine(" ")
            GoTo SAISIEETVERIFICATIONDELALETRESAISIE
FONCTIONAFFICHERSAISISSEZUNELETTREAUDEBUTDELASAISIEETVERIFICATIONDELALETRESAISIE:
            Console.Write("Saisissez une lettre : ")
            GoTo ATTENDRELASAISIEDELUTILISATEUR
FONCTIONPOURECRIREQUELUTILISATEURAPLUSDEVIE:
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.Write("Pascal est mort, il rejoignit sa femme, ses deux filles passeront leurs vies livrées à elle-même, mathilde qui a l'époque n'avais que 14 ans, a dû à elle seule élever sa soeur blandine alors agée de 7 ans, pour ce faire elle se mît a vendre tout ce qu'elle pouvais : meubles, ustensile, vêtements. Trés vite, il ne resta plus rien, si ce n'est qu'une petite boîte d'allumettes, cependant elles étaient confrontées a un dilemme cornélien, brûler les allumettes et se confronter au froid mordant de l'hiver ou les vendre pour pouvoir manger ne serais-ce qu'un peu plus longtemps, mathilde ne cogita pas longtemps, vendit les allumetes et offrit la nourriture a sa soeur, cela ne sera point suffisant, elles agonisèrent dans le froid et la faim, la fin approchant seule une pensée persistait dans l'esprit des deux soeurs, peut-être auraient-elles dû taper le bourreau, ces dernière périrent sur le plancher gelé de leur maison désormais vide. Tout cela à cause de vous, bien joué ;).")
            Console.WriteLine(" ")
            GoTo ending
FONCTIONAFFICHERMESSAGEQUANDLUTILISATEURTAPEUNELETREQUINESTPASDANSLEMOT:
            Console.Write("Cette lettre n'est pas dans le mot !")
            Console.WriteLine(" ")
            lesvie = lesvie - 1
            GoTo LIGNEENDESSOUSDELALIGNEGOTOFONCTIONAFFICHERMESSAGEQUANDLUTILISATEURTAPEUNELETREQUINESTPASDANSLEMOT
FONCTIONAFFICHERQUANDLUTILISATEURATAPERTOUTESLESLETREDUMOT:
            Console.Write("Félicitation, grâce à vôtre intervention Pascal a échapé a l'executation, il pu vivre heureux avec ses deux filles, blandine et mathilde.")
            Console.WriteLine(" ")
            GoTo ending
FONCTIONAFFICHERQUANDMOTSECRET:
            Console.Write("Les deux soeurs agonisantes, vivaient leurs dernières heures, quand tout d'un coup, elles entendirent quelqu'un toquer à la porte, c'était leur tante qui était la pour les secourir, grâce à qui elles vécurent heureuses.")
            Console.WriteLine(" ")
            GoTo ending
        End If

        Dim listedesmot(50)
        Dim valeur = 0
        listedesmot(valeur) = "angle"
        valeurplusplus(valeur)
        listedesmot(valeur) = "armoire"
        valeurplusplus(valeur)
        listedesmot(valeur) = "banc"
        valeurplusplus(valeur)
        listedesmot(valeur) = "bureau"
        valeurplusplus(valeur)
        listedesmot(valeur) = "cabinet"
        valeurplusplus(valeur)
        listedesmot(valeur) = "carreau"
        valeurplusplus(valeur)
        listedesmot(valeur) = "chaise"
        valeurplusplus(valeur)
        listedesmot(valeur) = "classe"
        valeurplusplus(valeur)
        listedesmot(valeur) = "clef"
        valeurplusplus(valeur)
        listedesmot(valeur) = "coin"
        valeurplusplus(valeur)
        listedesmot(valeur) = "couloir"
        valeurplusplus(valeur)
        listedesmot(valeur) = "dossier"
        valeurplusplus(valeur)
        listedesmot(valeur) = "eau"
        valeurplusplus(valeur)
        listedesmot(valeur) = "ecole"
        valeurplusplus(valeur)
        listedesmot(valeur) = "entrer"
        valeurplusplus(valeur)
        listedesmot(valeur) = "escalier"
        valeurplusplus(valeur)
        listedesmot(valeur) = "etagere"
        valeurplusplus(valeur)
        listedesmot(valeur) = "exterieur"
        valeurplusplus(valeur)
        listedesmot(valeur) = "fenetre"
        valeurplusplus(valeur)
        listedesmot(valeur) = "interieur"
        valeurplusplus(valeur)
        listedesmot(valeur) = "lavabo"
        valeurplusplus(valeur)
        listedesmot(valeur) = "lit"
        valeurplusplus(valeur)
        listedesmot(valeur) = "marche"
        valeurplusplus(valeur)
        listedesmot(valeur) = "matelas"
        valeurplusplus(valeur)
        listedesmot(valeur) = "maternelle"
        valeurplusplus(valeur)
        listedesmot(valeur) = "meuble"
        valeurplusplus(valeur)
        listedesmot(valeur) = "mousse"
        valeurplusplus(valeur)
        listedesmot(valeur) = "mur"
        valeurplusplus(valeur)
        listedesmot(valeur) = "peluche"
        valeurplusplus(valeur)
        listedesmot(valeur) = "placard"
        valeurplusplus(valeur)
        listedesmot(valeur) = "plafond"
        valeurplusplus(valeur)
        listedesmot(valeur) = "porte"
        valeurplusplus(valeur)
        listedesmot(valeur) = "poubelle"
        valeurplusplus(valeur)
        listedesmot(valeur) = "radiateur"
        valeurplusplus(valeur)
        listedesmot(valeur) = "rampe"
        valeurplusplus(valeur)
        listedesmot(valeur) = "rideau"
        valeurplusplus(valeur)
        listedesmot(valeur) = "robinet"
        valeurplusplus(valeur)
        listedesmot(valeur) = "salle"
        valeurplusplus(valeur)
        listedesmot(valeur) = "salon"
        valeurplusplus(valeur)
        listedesmot(valeur) = "serrure"
        valeurplusplus(valeur)
        listedesmot(valeur) = "serviette"
        valeurplusplus(valeur)
        listedesmot(valeur) = "siege"
        valeurplusplus(valeur)
        listedesmot(valeur) = "sieste"
        valeurplusplus(valeur)
        listedesmot(valeur) = "silence"
        valeurplusplus(valeur)
        listedesmot(valeur) = "sol"
        valeurplusplus(valeur)
        listedesmot(valeur) = "sommeil"
        valeurplusplus(valeur)
        listedesmot(valeur) = "sonnette"
        valeurplusplus(valeur)
        listedesmot(valeur) = "sortie"
        valeurplusplus(valeur)
        listedesmot(valeur) = "table"
        valeurplusplus(valeur)
        listedesmot(valeur) = "tableau"
        valeurplusplus(valeur)

        Randomize()
        Dim endroitdumot = Rnd()
        endroitdumot = 50 * endroitdumot
        endroitdumot = Int(endroitdumot)
        Dim lescaractèresaisi = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
        While True
LALIGNEOULEPROGRAMMECOMMENCEASELANCER:
            If (lesvie Xor 6) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 1) <> 0 And (lesvie Xor 0) Then
                imagepotanse()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 1) <> 0 And (lesvie Xor 0) Then
                imagepotanseavecuntète()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 6) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 1) <> 0 And (lesvie Xor 0) Then
                imagepotanseavecuntètesonvantreetcestbra()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 6) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 1) <> 0 And (lesvie Xor 0) Then
                imagepotanseavectoutlecorpsauflesextrémité()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 6) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 1) <> 0 And (lesvie Xor 0) Then
                imagepotanseavectoutlecorpsauflesextrémitéaveclamaingauche()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 6) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 1) <> 0 And (lesvie Xor 0) Then
                imagepotanseavectoutlecorpsauflesextrémitéaveclamaingaucheetlamaindroite()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 6) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 0) Then
                imagepotanseavectoutlecorpsauflesextrémitéaveclesmainetlepiedgauche()
            End If
            If (lesvie Xor 7) <> 0 And (lesvie Xor 6) <> 0 And (lesvie Xor 5) <> 0 And (lesvie Xor 4) <> 0 And (lesvie Xor 3) <> 0 And (lesvie Xor 2) <> 0 And (lesvie Xor 1) Then
                imagepotanseavectoutlecorpsauflesextrémitéaveclesmainetlepiedgaucheetlepieddroit()
                Console.WriteLine(" ")
                Console.Write("Le mot était : " + listedesmot(endroitdumot))
                GoTo FONCTIONPOURECRIREQUELUTILISATEURAPLUSDEVIE
            End If
            Console.WriteLine(" ")
            Dim estcequevousaveztoustapé = True
            For Each letterdumot As Char In listedesmot(endroitdumot)
                valeur = 0
                While True
                    If valeur = Asc(letterdumot) - 97 Then
                        If (lescaractèresaisi(valeur) <> False) Then
                            Console.Write(letterdumot)
                        Else
                            Console.Write("_")
                            estcequevousaveztoustapé = False
                        End If
                    End If
                    If valeur > 26 Then
                        GoTo Fin
                    End If
                    valeurplusplus(valeur)
                End While
Fin:
            Next
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            If estcequevousaveztoustapé = True Then
                GoTo FONCTIONAFFICHERQUANDLUTILISATEURATAPERTOUTESLESLETREDUMOT
            End If
SAISIEETVERIFICATIONDELALETRESAISIE:
            Dim caractèretapé As Char
            Dim phrasetapée As String
            GoTo FONCTIONAFFICHERSAISISSEZUNELETTREAUDEBUTDELASAISIEETVERIFICATIONDELALETRESAISIE
ATTENDRELASAISIEDELUTILISATEUR:
            phrasetapée = LCase(Console.ReadLine())
            If phrasetapée = "bourreau" Then
                GoTo FONCTIONAFFICHERQUANDMOTSECRET
            End If
            Try
                caractèretapé = phrasetapée(0)
            Catch
                caractèretapé = Chr(0)
            End Try
            If Asc(caractèretapé) <> 0 Then
                If Not (Asc(caractèretapé) <> 97 And Asc(caractèretapé) <> 98 And Asc(caractèretapé) <> 99 And Asc(caractèretapé) <> 100 And Asc(caractèretapé) <> 101 And Asc(caractèretapé) <> 102 And Asc(caractèretapé) <> 103 And Asc(caractèretapé) <> 104 And Asc(caractèretapé) <> 105 And Asc(caractèretapé) <> 106 And Asc(caractèretapé) <> 107 And Asc(caractèretapé) <> 108 And Asc(caractèretapé) <> 109 And Asc(caractèretapé) <> 110 And Asc(caractèretapé) <> 111 And Asc(caractèretapé) <> 112 And Asc(caractèretapé) <> 113 And Asc(caractèretapé) <> 114 And Asc(caractèretapé) <> 115 And Asc(caractèretapé) <> 116 And Asc(caractèretapé) <> 117 And Asc(caractèretapé) <> 118 And Asc(caractèretapé) <> 119 And Asc(caractèretapé) <> 120 And Asc(caractèretapé) <> 121 And Asc(caractèretapé) <> 122) Then
                    If lescaractèresaisi(Asc(caractèretapé) - 97) = True Then
                        GoTo FONCTIONSIONADEJATAPELALETRE
                    End If
                Else
                    GoTo FONCTIONAFFICHERLEMESSAGEQUANDONTAPEPASUNELETTRE
                End If
            Else
                GoTo FONCTIONAFFICHERLEMESSAGEQUANDONTAPERIEN
            End If
            If (Not (Asc(caractèretapé) <> 97 And Asc(caractèretapé) <> 98 And Asc(caractèretapé) <> 99 And Asc(caractèretapé) <> 100 And Asc(caractèretapé) <> 101 And Asc(caractèretapé) <> 102 And Asc(caractèretapé) <> 103 And Asc(caractèretapé) <> 104 And Asc(caractèretapé) <> 105 And Asc(caractèretapé) <> 106 And Asc(caractèretapé) <> 107 And Asc(caractèretapé) <> 108 And Asc(caractèretapé) <> 109 And Asc(caractèretapé) <> 110 And Asc(caractèretapé) <> 111 And Asc(caractèretapé) <> 112 And Asc(caractèretapé) <> 113 And Asc(caractèretapé) <> 114 And Asc(caractèretapé) <> 115 And Asc(caractèretapé) <> 116 And Asc(caractèretapé) <> 117 And Asc(caractèretapé) <> 118 And Asc(caractèretapé) <> 119 And Asc(caractèretapé) <> 120 And Asc(caractèretapé) <> 121 And Asc(caractèretapé) <> 122)) Then
                GoTo FINVERIFICATIONDELALETTRETAPÉ
                If Not (Asc(caractèretapé) <> 97 And Asc(caractèretapé) <> 98 And Asc(caractèretapé) <> 99 And Asc(caractèretapé) <> 100 And Asc(caractèretapé) <> 101 And Asc(caractèretapé) <> 102 And Asc(caractèretapé) <> 103 And Asc(caractèretapé) <> 104 And Asc(caractèretapé) <> 105 And Asc(caractèretapé) <> 106 And Asc(caractèretapé) <> 107 And Asc(caractèretapé) <> 108 And Asc(caractèretapé) <> 109 And Asc(caractèretapé) <> 110 And Asc(caractèretapé) <> 111 And Asc(caractèretapé) <> 112 And Asc(caractèretapé) <> 113 And Asc(caractèretapé) <> 114 And Asc(caractèretapé) <> 115 And Asc(caractèretapé) <> 116 And Asc(caractèretapé) <> 117 And Asc(caractèretapé) <> 118 And Asc(caractèretapé) <> 119 And Asc(caractèretapé) <> 120 And Asc(caractèretapé) <> 121 And Asc(caractèretapé) <> 122) Then
                    If lescaractèresaisi(Asc(caractèretapé) - 97) = True Then
                        GoTo FONCTIONSIONADEJATAPELALETRE
                    End If
                Else
                    GoTo FONCTIONAFFICHERLEMESSAGEQUANDONTAPEPASUNELETTRE
                End If
            End If
FINVERIFICATIONDELALETTRETAPÉ:
            lescaractèresaisi(Asc(caractèretapé) - 97) = True
            Dim trouvé = False
            For Each letterdumot In listedesmot(endroitdumot)
                If (letterdumot = caractèretapé) Then
                    trouvé = True
                End If
            Next
            If trouvé = False Then
                GoTo FONCTIONAFFICHERMESSAGEQUANDLUTILISATEURTAPEUNELETREQUINESTPASDANSLEMOT
LIGNEENDESSOUSDELALIGNEGOTOFONCTIONAFFICHERMESSAGEQUANDLUTILISATEURTAPEUNELETREQUINESTPASDANSLEMOT:
            End If
        End While
ending:
        Console.Read()
    End Sub
End Module
