using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
public GameObject menu;
public bool intering;
public float hue;
public Player play;
public TMP_Text textox;
public TMP_Text textojx;
public TMP_Text textokx;
public TMP_Text textocx;
public TMP_Text textorx;
public TMP_Text texto;
public TMP_Text textoj;
public TMP_Text textok;
public TMP_Text textoc;
public TMP_Text textor;
public TMP_Text texto2;
public TMP_Text textoj2;
public TMP_Text textok2;
public TMP_Text textoc2;
public TMP_Text textor2;
public TMP_Text texto3;
public TMP_Text textoj3;
public TMP_Text textok3;
public TMP_Text textoc3;
public TMP_Text textor3;
public TMP_Text texto4;
public TMP_Text textoj4;
public TMP_Text textok4;
public TMP_Text textoc4;
public TMP_Text textor4;
public TMP_Text texto5;
public TMP_Text textoj5;
public TMP_Text textok5;
public TMP_Text textoc5;
public TMP_Text textor5;
public Data dt;
public bool freeze;
public string idioma;
public bool playst;
public bool xbox;
public Rigidbody rbd;
public float c1;
public float c2;
public float c3;
public float c4;
public float c5;
public float luck;
public Image im1;
public Image im2;
public Image im3;
public Image im4;
public Image im5;
public Sprite O;
public Sprite I;
public Sprite II;
public Sprite III;
public Sprite IV;
public Sprite V;
public Sprite VI;
public Sprite VII;
public Sprite VIII;
public Sprite IX;
public Sprite X;
public Sprite XI;
public Sprite XII;
public Sprite XIII;
public Sprite XIV;
public Sprite XV;
public Sprite XVI;
public Sprite XVII;
public Sprite XVIII;
public Sprite XIX;
public Sprite XX;
public Sprite XXI;
public bool ef1;
public bool ef2;
public bool ef3;
public bool ef4;
public bool ef5;
public Clock cl;
public Cameras cam;
public CharacterController controller;
public bool crdd;
public GameObject hng;
public bool pre;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        freeze = play.freeze;
        idioma = dt.idioma;
        playst = play.playst;
        xbox = play.xbox;
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && freeze == false && cl.power <= 10 && controller.height >= 1)
              {
if(crdd == false)
{
                 play.freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
cam.crd = true;
play.texm = true;
play.textorder = -77;
play.writing = false;
}
              }
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && freeze == false && controller.height <= 0.9f && crdd == true)
              {
                 play.freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
play.texm = true;
play.textorder = 120;
play.timestop = true;
play.writing = false;
              }

              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && freeze == false && cl.power >= 11 && controller.height >= 1 && crdd == false)
              {
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
cam.crd = true;
ef1 = false;
ef2 = false;
ef3 = false;
ef4 = false;
ef5 = false;
                 cl.power -= 10;
                 luck = 0;
                 play.freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        int rng = Random.Range(1, 22);
        c1 = rng;
        int rng2 = Random.Range(1, 22);
        c2 = rng2;
        int rng3 = Random.Range(1, 22);
        c3 = rng3;
        int rng4 = Random.Range(1, 22);
        c4 = rng4;
        int rng5 = Random.Range(1, 22);
        c5 = rng5;
if(c1 == c2)
{
c1 = 1;
}
if(c2 == c3)
{
c2 = 1;
}
if(c3 == c4)
{
c3 = 1;
}
if(c4 == c5)
{
c5 = 1;
}
if(c1 == c3)
{
c3 = 1;
}
if(c1 == c4)
{
c4 = 1;
}
if(c1 == c5)
{
c1 = 1;
}
if(c2 == c4)
{
c4 = 1;
}
if(c2 == c5)
{
c2 = 1;
}
if(c3 == c5)
{
c5 = 22;
}

if(c1 <= 11)
{
luck += 1;
}
if(c2 <= 11)
{
luck += 1;
}
if(c3 <= 11)
{
luck += 1;
}
if(c4 <= 11)
{
luck += 1;
}
if(c5 <= 11)
{
luck += 1;
}

play.texm = true;
if(pre == false)
{
play.textorder = -123;
}
if(pre == true)
{
play.textorder = -133;
play.timestop = true;
pre = false;
}
play.writing = false;
play.luck = luck;
              }





//CARD1
if(c1 == 1)
{
Color verdeChillon = new Color(0f, 1f, 0f);

texto.color = verdeChillon;
textoj.color = verdeChillon;
textok.color = verdeChillon;
textoc.color = verdeChillon;
textor.color = verdeChillon;
im1.sprite = O;
if(idioma == "ingles")
{
    texto.text = "+ Nothing";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Nada";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Rien";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Nichts";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Niente";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Nada";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ 何もない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 아무것도";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 没有东西";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Ничего";
}
}
if(c1 == 2)
{
if(ef1 == false)
{
dt.taco += 1;
ef1 = true;
}
Color moradoNeon = new Color(0.7f, 0f, 1f);

texto.color = moradoNeon;
textoj.color = moradoNeon;
textok.color = moradoNeon;
textoc.color = moradoNeon;
textor.color = moradoNeon;
im1.sprite = I;
if(idioma == "ingles")
{
    texto.text = "+ Speed";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Velocidad";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Vitesse";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Geschwindigkeit";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Velocita";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Velocidade";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ スピード";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 속도";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 速度";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Скорость";
}
}
if(c1 == 3)
{
if(ef1 == false)
{
dt.burr += 1;
ef1 = true;
}
Color azulNeon = new Color(0f, 0.8f, 1f);

texto.color = azulNeon;
textoj.color = azulNeon;
textok.color = azulNeon;
textoc.color = azulNeon;
textor.color = azulNeon;
im1.sprite = II;
if(idioma == "ingles")
{
    texto.text = "+ Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Resistencia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Endurance";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Ausdauer";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Resistenza";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Resistencia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ スタミナ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 스태미나";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 耐力";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Выносливость";
}
}
if(c1 == 4)
{
if(ef1 == false)
{
dt.nach += 1;
ef1 = true;
}
texto.color = new Color(1f, 0f, 0.8f);
textoj.color = new Color(1f, 0f, 0.8f);
textok.color = new Color(1f, 0f, 0.8f);
textoc.color = new Color(1f, 0f, 0.8f);
textor.color = new Color(1f, 0f, 0.8f);
im1.sprite = III;
if(idioma == "ingles")
{
    texto.text = "+ Flashlight";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Linterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Lampe de poche";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Taschenlampe";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Torcia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Lanterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ 懐中電灯";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 손전등";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 手电筒";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Фонарь";
}
}
if(c1 == 5)
{
if(ef1 == false)
{
dt.ques += 1;
ef1 = true;
}
Color rosaNeon = new Color(1f, 0.3f, 0.9f);

texto.color = rosaNeon;
textoj.color = rosaNeon;
textok.color = rosaNeon;
textoc.color = rosaNeon;
textor.color = rosaNeon;
im1.sprite = VI;
if(idioma == "ingles")
{
    texto.text = "+ Stamina Recovery";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Recuperacion Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Recuperation d'endurance";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Ausdauer Wiederherstellung";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Recupero Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Recuperacao de Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ スタミナ回復";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 스태미너 회복";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 耐力恢复";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Восстановление выносливости";
}
}

if(c1 == 6)
{
if(ef1 == false)
{
dt.frij += 1;
ef1 = true;
}
Color rosaNeon = new Color(1f, 0.3f, 0.9f);

texto.color = new Color(1f, 0f, 0.8f);
textoj.color = new Color(1f, 0f, 0.8f);
textok.color = new Color(1f, 0f, 0.8f);
textoc.color = new Color(1f, 0f, 0.8f);
textor.color = new Color(1f, 0f, 0.8f);
im1.sprite = VIII;
if(idioma == "ingles")
{
    texto.text = "+ Flashlight Range";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Alcance Linterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Portee de la lampe de poche";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Taschenlampenreichweite";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Raggio Torcia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Alcance da Lanterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ 懐中電灯の範囲";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 손전등 범위";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 手电筒射程";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Дальность фонаря";
}
}

if(c1 == 7)
{
if(ef1 == false)
{
dt.ench += 1;
ef1 = true;
}
Color azulNeon = new Color(0f, 0.8f, 1f);

texto.color = azulNeon;
textoj.color = azulNeon;
textok.color = azulNeon;
textoc.color = azulNeon;
textor.color = azulNeon;
im1.sprite = X;

if(idioma == "ingles")
{
    texto.text = "+ Microphone Silence";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Silencio Microfono";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Silencieux du Microphone";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Mikrofon Stummschalten";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Microfono Silenzio";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Silencio Microfone";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ マイクミュート";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 마이크 음소거";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 麦克风静音";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Выключить микрофон";
}
}

if(c1 == 8)
{
if(ef1 == false)
{
dt.tam += 1;
ef1 = true;
}
Color verdeChillon = new Color(0f, 1f, 0f);

texto.color = verdeChillon;
textoj.color = verdeChillon;
textok.color = verdeChillon;
textoc.color = verdeChillon;
textor.color = verdeChillon;
im1.sprite = XI;
if(idioma == "ingles")
{
    texto.text = "+ Step Silence";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Silencio Pasos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Silencieux des pas";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Schrittgerauschlos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Silenzio Passi";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Silencio Passos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ 足音を消す";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 발소리 감추기";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 步伐静音";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Бесшумные шаги";
}
}

if(c1 == 9)
{
if(ef1 == false)
{
dt.gua += 1;
ef1 = true;
}
Color naranjaNeon = new Color(1f, 0.5f, 0f);

texto.color = naranjaNeon;
textoj.color = naranjaNeon;
textok.color = naranjaNeon;
textoc.color = naranjaNeon;
textor.color = naranjaNeon;
im1.sprite = XIV;
if(idioma == "ingles")
{
    texto.text = "+ Llorona Blindness";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Ceguera Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Cecite Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Llorona Blindheit";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Cecita Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Cegueira Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ ロロナの盲目";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 로로나 실명";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 洛罗纳失明";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Слепота Ллорона";
}
}

if(c1 == 10)
{
if(ef1 == false)
{
dt.ques += 1;
dt.nach += 1;
ef1 = true;
}
Color azulNeon = new Color(0f, 0.8f, 1f);

texto.color = azulNeon;
textoj.color = azulNeon;
textok.color = azulNeon;
textoc.color = azulNeon;
textor.color = azulNeon;
im1.sprite = XVII;
if(idioma == "ingles")
{
    texto.text = "+ Stamina / Stamina Recovery";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Stamina / Recuperacion Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Endurance / Recuperation d'endurance";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Ausdauer / Ausdauer Wiederherstellung";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Stamina / Recupero Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Stamina / Recuperacao de Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ スタミナ / スタミナ回復";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 스태미너 / 스태미너 회복";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 耐力 / 耐力恢复";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Выносливость / Восстановление выносливости";
}
}

if(c1 == 11)
{
if(ef1 == false)
{
dt.ques += 1;
dt.nach += 1;
ef1 = true;
}
Color naranjaNeon = new Color(1f, 0.5f, 0f);

texto.color = naranjaNeon;
textoj.color = naranjaNeon;
textok.color = naranjaNeon;
textoc.color = naranjaNeon;
textor.color = naranjaNeon;
im1.sprite = XIX;
if(idioma == "ingles")
{
    texto.text = "+ Microphone Silence / Step Silence";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Silencio Microfono / Silencio Pasos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Silence Micro / Silencieux des pas";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Mikrofon Stille / Schrittgerauschlos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Silenzio Microfono / Silenzio Passi";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Silencio Microfone / Silencio Passos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ マイク消音 / 足音を消す";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 마이크 음소거 / 발소리 감추기";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 麦克风静音 / 步伐静音";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Отключение микрофона / Бесшумные шаги";
}
}

if(c1 == 12)
{
if(ef1 == false)
{
                  dt.gua += 1;
                  dt.tam += 1;
                  dt.ench += 1;
                  dt.frij += 1;
                  dt.ques += 1;
                  dt.nach += 1;
                  dt.burr += 1;
                  dt.taco += 1;
ef1 = true;
}
        hue += Time.deltaTime * 0.5f;
        if (hue > 1) hue = 0;

        Color color = Color.HSVToRGB(hue, 1, 1);
        texto.color = color;
        textoj.color = color;
        textok.color = color;
        textoc.color = color;
        textor.color = color;
im1.sprite = XXI;
if(idioma == "ingles")
{
    texto.text = "+ Everything";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Todo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Tout";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Alles";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Tutto";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Tudo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ すべて";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 모든 것";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 一切";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Всё";
}
}



if(c1 == 21)
{
if(ef1 == false)
{
dt.nach -= 1;
ef1 = true;
}
Color rojoNeon = new Color(1f, 0f, 0f);

texto.color = rojoNeon;
textoj.color = rojoNeon;
textok.color = rojoNeon;
textoc.color = rojoNeon;
textor.color = rojoNeon;
im1.sprite = IV;
if(idioma == "ingles")
{
    texto.text = "- Flashlight";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Linterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Lampe de poche";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Taschenlampe";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Torcia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Lanterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- 懐中電灯";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 손전등";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 手电筒";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Фонарь";
}
}
if(c1 == 13)
{
if(ef1 == false)
{
dt.taco -= 1;
ef1 = true;
}
Color verdeChillon = new Color(0f, 1f, 0f);

texto.color = verdeChillon;
textoj.color = verdeChillon;
textok.color = verdeChillon;
textoc.color = verdeChillon;
textor.color = verdeChillon;
im1.sprite = V;
if(idioma == "ingles")
{
    texto.text = "- Speed";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Velocidad";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Vitesse";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Geschwindigkeit";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Velocita";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Velocidade";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- スピード";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 속도";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 速度";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Скорость";
}
}
if(c1 == 14)
{
if(ef1 == false)
{
dt.burr -= 1;
ef1 = true;
}
Color naranjaNeon = new Color(1f, 0.5f, 0f);

texto.color = naranjaNeon;
textoj.color = naranjaNeon;
textok.color = naranjaNeon;
textoc.color = naranjaNeon;
textor.color = naranjaNeon;
im1.sprite = VII;
if(idioma == "ingles")
{
    texto.text = "- Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Resistencia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Endurance";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Ausdauer";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Resistenza";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Resistencia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- スタミナ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 스태미나";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 耐力";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Выносливость";
}
}
if(c1 == 15)
{
if(ef1 == false)
{
dt.ques -= 1;
ef1 = true;
}
Color moradoNeon = new Color(0.7f, 0f, 1f);

texto.color = moradoNeon;
textoj.color = moradoNeon;
textok.color = moradoNeon;
textoc.color = moradoNeon;
textor.color = moradoNeon;
im1.sprite = IX;
if(idioma == "ingles")
{
    texto.text = "- Stamina Recovery";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Recuperacion Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Recuperation d'endurance";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Ausdauer Wiederherstellung";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Recupero Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Recuperacao de Stamina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- スタミナ回復";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 스태미너 회복";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 耐力恢复";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Восстановление выносливости";
}
}
if(c1 == 16)
{
if(ef1 == false)
{
dt.frij -= 1;
ef1 = true;
}
Color rosaNeon = new Color(1f, 0.3f, 0.9f);

texto.color = rosaNeon;
textoj.color = rosaNeon;
textok.color = rosaNeon;
textoc.color = rosaNeon;
textor.color = rosaNeon;
im1.sprite = XII;
if(idioma == "ingles")
{
    texto.text = "- Flashlight Range";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Alcance Linterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Portee de la lampe de poche";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Taschenlampenreichweite";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Raggio Torcia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Alcance da Lanterna";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- 懐中電灯の範囲";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 손전등 범위";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 手电筒射程";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Дальность фонаря";
}
}
if(c1 == 18)
{
if(ef1 == false)
{
dt.ench -= 1;
ef1 = true;
}
Color moradoNeon = new Color(0.7f, 0f, 1f);

texto.color = moradoNeon;
textoj.color = moradoNeon;
textok.color = moradoNeon;
textoc.color = moradoNeon;
textor.color = moradoNeon;
im1.sprite = XVI;
if(idioma == "ingles")
{
    texto.text = "- Microphone Silence";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Silencio Microfono";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Silencieux du Microphone";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Mikrofon Stummschalten";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Microfono Silenzio";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Silencio Microfone";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- マイクミュート";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 마이크 음소거";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 麦克风静音";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Выключить микрофон";
}
}
if(c1 == 19)
{
if(ef1 == false)
{
dt.tam -= 1;
ef1 = true;
}
texto.color = new Color(1f, 0f, 0.8f);
textoj.color = new Color(1f, 0f, 0.8f);
textok.color = new Color(1f, 0f, 0.8f);
textoc.color = new Color(1f, 0f, 0.8f);
textor.color = new Color(1f, 0f, 0.8f);
im1.sprite = XVIII;
if(idioma == "ingles")
{
    texto.text = "- Step Silence";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Silencio Pasos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Silencieux des pas";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Schrittgerauschlos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Silenzio Passi";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Silencio Passos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- 足音を消す";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 발소리 감추기";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 步伐静音";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Бесшумные шаги";
}
}

if(c1 == 20)
{
if(ef1 == false)
{
dt.gua -= 1;
ef1 = true;
}
texto.color = new Color(1f, 0f, 0.8f);
textoj.color = new Color(1f, 0f, 0.8f);
textok.color = new Color(1f, 0f, 0.8f);
textoc.color = new Color(1f, 0f, 0.8f);
textor.color = new Color(1f, 0f, 0.8f);
im1.sprite = XX;
if(idioma == "ingles")
{
    texto.text = "- Llorona Blindness";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Ceguera Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Cecite Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Llorona Blindheit";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Cecita Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Cegueira Llorona";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- ロロナの盲目";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 로로나 실명";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 洛罗纳失明";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Слепота Ллорона";
}
}
if(c1 == 17)
{
if(ef1 == false)
{
                  dt.gua -= 1;
                  dt.tam -= 1;
                  dt.ench -= 1;
                  dt.frij -= 1;
                  dt.ques -= 1;
                  dt.nach -= 1;
                  dt.burr -= 1;
                  dt.taco -= 1;
ef1 = true;
}
Color rojoNeon = new Color(1f, 0f, 0f);

texto.color = rojoNeon;
textoj.color = rojoNeon;
textok.color = rojoNeon;
textoc.color = rojoNeon;
textor.color = rojoNeon;
im1.sprite = XV;
if(idioma == "ingles")
{
    texto.text = "- Everything";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "- Todo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "- Tout";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "- Alles";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "- Tutto";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "- Tudo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "- すべて";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "- 모든 것";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "- 一切";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "- Всё";
}
}
if(c1 == 22)
{
Color rojoNeon = new Color(1f, 0f, 0f);

texto.color = rojoNeon;
textoj.color = rojoNeon;
textok.color = rojoNeon;
textoc.color = rojoNeon;
textor.color = rojoNeon;
im1.sprite = XIII;
if(idioma == "ingles")
{
    texto.text = "+ Death";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "+ Muerte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "+ Mort";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "+ Tod";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "+ Morte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "+ Morte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "+ 死";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "+ 죽음";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "+ 死亡";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "+ Смерть";
}
}







//CARD2
if(c2 == 1)
{
Color verdeChillon = new Color(0f, 1f, 0f);

texto2.color = verdeChillon;
textoj2.color = verdeChillon;
textok2.color = verdeChillon;
textoc2.color = verdeChillon;
textor2.color = verdeChillon;
im2.sprite = O;
if(idioma == "ingles")
{
    texto2.text = "+ Nothing";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "+ Nada";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "+ Rien";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "+ Nichts";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "+ Niente";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "+ Nada";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "+ 何もない";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "+ 아무것도";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "+ 没有东西";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "+ Ничего";
}
}
if(c2 == 2)
{
if(ef2 == false)
{
dt.taco += 1;
ef2 = true;
}
Color moradoNeon = new Color(0.7f, 0f, 1f);

texto2.color = moradoNeon;
textoj2.color = moradoNeon;
textok2.color = moradoNeon;
textoc2.color = moradoNeon;
textor2.color = moradoNeon;
im2.sprite = I;
if(idioma == "ingles")
{
    texto2.text = "+ Speed";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "+ Velocidad";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "+ Vitesse";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "+ Geschwindigkeit";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "+ Velocita";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "+ Velocidade";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "+ スピード";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "+ 속도";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "+ 速度";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "+ Скорость";
}
}
if(c2 == 3)
{
    if(ef2 == false)
    {
        dt.burr += 1;
        ef2 = true;
    }
    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto2.color = azulNeon;
    textoj2.color = azulNeon;
    textok2.color = azulNeon;
    textoc2.color = azulNeon;
    textor2.color = azulNeon;
    im2.sprite = II;

    if(idioma == "ingles")
    {
        texto2.text = "+ Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Resistencia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Endurance";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Ausdauer";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Resistenza";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Resistencia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ スタミナ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 스태미나";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 耐力";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Выносливость";
    }
}
if(c2 == 4)
{
    if(ef2 == false)
    {
        dt.nach += 1;
        ef2 = true;
    }

    texto2.color = new Color(1f, 0f, 0.8f);
    textoj2.color = new Color(1f, 0f, 0.8f);
    textok2.color = new Color(1f, 0f, 0.8f);
    textoc2.color = new Color(1f, 0f, 0.8f);
    textor2.color = new Color(1f, 0f, 0.8f);
    im2.sprite = III;

    if(idioma == "ingles")
    {
        texto2.text = "+ Flashlight";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Linterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Lampe de poche";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Taschenlampe";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Torcia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Lanterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ 懐中電灯";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 손전등";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 手电筒";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Фонарь";
    }
}
if(c2 == 5)
{
    if(ef2 == false)
    {
        dt.ques += 1;
        ef2 = true;
    }
    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto2.color = rosaNeon;
    textoj2.color = rosaNeon;
    textok2.color = rosaNeon;
    textoc2.color = rosaNeon;
    textor2.color = rosaNeon;
    im2.sprite = VI;

    if(idioma == "ingles")
    {
        texto2.text = "+ Stamina Recovery";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Recuperacion Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Recuperation d'endurance";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Ausdauer Wiederherstellung";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Recupero Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Recuperacao de Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ スタミナ回復";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 스태미너 회복";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 耐力恢复";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Восстановление выносливости";
    }
}

if(c2 == 6)
{
    if(ef2 == false)
    {
        dt.frij += 1;
        ef2 = true;
    }

    Color rosa = new Color(1f, 0f, 0.8f);

    texto2.color = rosa;
    textoj2.color = rosa;
    textok2.color = rosa;
    textoc2.color = rosa;
    textor2.color = rosa;
    im2.sprite = VIII;

    if(idioma == "ingles")
    {
        texto2.text = "+ Flashlight Range";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Alcance Linterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Portee de la lampe de poche";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Taschenlampenreichweite";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Raggio Torcia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Alcance da Lanterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ 懐中電灯の範囲";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 손전등 범위";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 手电筒射程";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Дальность фонаря";
    }
}

if(c2 == 7)
{
    if(ef2 == false)
    {
        dt.ench += 1;
        ef2 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto2.color = azulNeon;
    textoj2.color = azulNeon;
    textok2.color = azulNeon;
    textoc2.color = azulNeon;
    textor2.color = azulNeon;
    im2.sprite = X;

    if(idioma == "ingles")
    {
        texto2.text = "+ Microphone Silence";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Silencio Microfono";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Silencieux du Microphone";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Mikrofon Stummschalten";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Microfono Silenzio";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Silencio Microfone";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ マイクミュート";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 마이크 음소거";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 麦克风静音";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Выключить микрофон";
    }
}

if(c2 == 8)
{
    if(ef2 == false)
    {
        dt.tam += 1;
        ef2 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto2.color = verdeChillon;
    textoj2.color = verdeChillon;
    textok2.color = verdeChillon;
    textoc2.color = verdeChillon;
    textor2.color = verdeChillon;
    im2.sprite = XI;

    if(idioma == "ingles")
    {
        texto2.text = "+ Step Silence";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Silencio Pasos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Silencieux des pas";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Schrittgerauschlos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Silenzio Passi";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Silencio Passos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ 足音を消す";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 발소리 감추기";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 步伐静音";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Бесшумные шаги";
    }
}
if(c2 == 9)
{
    if(ef2 == false)
    {
        dt.gua += 1;
        ef2 = true;
    }
    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto2.color = naranjaNeon;
    textoj2.color = naranjaNeon;
    textok2.color = naranjaNeon;
    textoc2.color = naranjaNeon;
    textor2.color = naranjaNeon;
    im2.sprite = XIV;

    if(idioma == "ingles")
    {
        texto2.text = "+ Llorona Blindness";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Ceguera Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Cecite Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Llorona Blindheit";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Cecita Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Cegueira Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ ロロナの盲目";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 로로나 실명";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 洛罗纳失明";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Слепота Ллорона";
    }
}

if(c2 == 10)
{
    if(ef2 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef2 = true;
    }
    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto2.color = azulNeon;
    textoj2.color = azulNeon;
    textok2.color = azulNeon;
    textoc2.color = azulNeon;
    textor2.color = azulNeon;
    im2.sprite = XVII;

    if(idioma == "ingles")
    {
        texto2.text = "+ Stamina / Stamina Recovery";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Stamina / Recuperacion Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Endurance / Recuperation d'endurance";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Ausdauer / Ausdauer Wiederherstellung";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Stamina / Recupero Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Stamina / Recuperacao de Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ スタミナ / スタミナ回復";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 스태미너 / 스태미너 회복";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 耐力 / 耐力恢复";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Выносливость / Восстановление выносливости";
    }
}

if(c2 == 11)
{
    if(ef2 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef2 = true;
    }
    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto2.color = naranjaNeon;
    textoj2.color = naranjaNeon;
    textok2.color = naranjaNeon;
    textoc2.color = naranjaNeon;
    textor2.color = naranjaNeon;
    im2.sprite = XIX;

    if(idioma == "ingles")
    {
        texto2.text = "+ Microphone Silence / Step Silence";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Silencio Microfono / Silencio Pasos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Silence Micro / Silencieux des pas";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Mikrofon Stille / Schrittgerauschlos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Silenzio Microfono / Silenzio Passi";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Silencio Microfone / Silencio Passos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ マイク消音 / 足音を消す";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 마이크 음소거 / 발소리 감추기";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 麦克风静音 / 步伐静音";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Отключение микрофона / Бесшумные шаги";
    }
}

if(c2 == 12)
{
    if(ef2 == false)
    {
        dt.gua += 1;
        dt.tam += 1;
        dt.ench += 1;
        dt.frij += 1;
        dt.ques += 1;
        dt.nach += 1;
        dt.burr += 1;
        dt.taco += 1;
        ef2 = true;
    }

    hue += Time.deltaTime * 0.5f;
    if (hue > 1) hue = 0;

    Color color = Color.HSVToRGB(hue, 1, 1);
    texto2.color = color;
    textoj2.color = color;
    textok2.color = color;
    textoc2.color = color;
    textor2.color = color;
    im2.sprite = XXI;

    if(idioma == "ingles")
    {
        texto2.text = "+ Everything";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Todo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Tout";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Alles";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Tutto";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Tudo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ すべて";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 모든 것";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 一切";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Всё";
    }
}


if(c2 == 21)
{
    if(ef2 == false)
    {
        dt.nach -= 1;
        ef2 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto2.color = rojoNeon;
    textoj2.color = rojoNeon;
    textok2.color = rojoNeon;
    textoc2.color = rojoNeon;
    textor2.color = rojoNeon;
    im2.sprite = IV;

    if(idioma == "ingles")
    {
        texto2.text = "- Flashlight";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Linterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Lampe de poche";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Taschenlampe";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Torcia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Lanterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- 懐中電灯";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 손전등";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 手电筒";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Фонарь";
    }
}

if(c2 == 13)
{
    if(ef2 == false)
    {
        dt.taco -= 1;
        ef2 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto2.color = verdeChillon;
    textoj2.color = verdeChillon;
    textok2.color = verdeChillon;
    textoc2.color = verdeChillon;
    textor2.color = verdeChillon;
    im2.sprite = V;

    if(idioma == "ingles")
    {
        texto2.text = "- Speed";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Velocidad";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Vitesse";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Geschwindigkeit";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Velocita";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Velocidade";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- スピード";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 속도";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 速度";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Скорость";
    }
}
if(c2 == 14)
{
    if(ef2 == false)
    {
        dt.burr -= 1;
        ef2 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto2.color = naranjaNeon;
    textoj2.color = naranjaNeon;
    textok2.color = naranjaNeon;
    textoc2.color = naranjaNeon;
    textor2.color = naranjaNeon;
    im2.sprite = VII;

    if(idioma == "ingles")
    {
        texto2.text = "- Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Resistencia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Endurance";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Ausdauer";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Resistenza";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Resistencia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- スタミナ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 스태미나";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 耐力";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Выносливость";
    }
}
if(c2 == 15)
{
    if(ef2 == false)
    {
        dt.ques -= 1;
        ef2 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto2.color = moradoNeon;
    textoj2.color = moradoNeon;
    textok2.color = moradoNeon;
    textoc2.color = moradoNeon;
    textor2.color = moradoNeon;
    im2.sprite = IX;

    if(idioma == "ingles")
    {
        texto2.text = "- Stamina Recovery";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Recuperacion Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Recuperation d'endurance";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Ausdauer Wiederherstellung";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Recupero Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Recuperacao de Stamina";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- スタミナ回復";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 스태미너 회복";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 耐力恢复";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Восстановление выносливости";
    }
}
if(c2 == 16)
{
    if(ef2 == false)
    {
        dt.frij -= 1;
        ef2 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto2.color = rosaNeon;
    textoj2.color = rosaNeon;
    textok2.color = rosaNeon;
    textoc2.color = rosaNeon;
    textor2.color = rosaNeon;
    im2.sprite = XII;

    if(idioma == "ingles")
    {
        texto2.text = "- Flashlight Range";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Alcance Linterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Portee de la lampe de poche";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Taschenlampenreichweite";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Raggio Torcia";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Alcance da Lanterna";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- 懐中電灯の範囲";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 손전등 범위";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 手电筒射程";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Дальность фонаря";
    }
}
if(c2 == 18)
{
    if(ef2 == false)
    {
        dt.ench -= 1;
        ef2 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto2.color = moradoNeon;
    textoj2.color = moradoNeon;
    textok2.color = moradoNeon;
    textoc2.color = moradoNeon;
    textor2.color = moradoNeon;
    im2.sprite = XVI;

    if(idioma == "ingles")
    {
        texto2.text = "- Microphone Silence";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Silencio Microfono";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Silencieux du Microphone";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Mikrofon Stummschalten";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Microfono Silenzio";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Silencio Microfone";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- マイクミュート";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 마이크 음소거";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 麦克风静音";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Выключить микрофон";
    }
}
if(c2 == 19)
{
    if(ef2 == false)
    {
        dt.tam -= 1;
        ef2 = true;
    }

    texto2.color = new Color(1f, 0f, 0.8f);
    textoj2.color = new Color(1f, 0f, 0.8f);
    textok2.color = new Color(1f, 0f, 0.8f);
    textoc2.color = new Color(1f, 0f, 0.8f);
    textor2.color = new Color(1f, 0f, 0.8f);
    im2.sprite = XVIII;

    if(idioma == "ingles")
    {
        texto2.text = "- Step Silence";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Silencio Pasos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Silencieux des pas";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Schrittgerauschlos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Silenzio Passi";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Silencio Passos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- 足音を消す";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 발소리 감추기";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 步伐静音";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Бесшумные шаги";
    }
}

if(c2 == 20)
{
    if(ef2 == false)
    {
        dt.gua -= 1;
        ef2 = true;
    }

    texto2.color = new Color(1f, 0f, 0.8f);
    textoj2.color = new Color(1f, 0f, 0.8f);
    textok2.color = new Color(1f, 0f, 0.8f);
    textoc2.color = new Color(1f, 0f, 0.8f);
    textor2.color = new Color(1f, 0f, 0.8f);
    im2.sprite = XX;

    if(idioma == "ingles")
    {
        texto2.text = "- Llorona Blindness";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Ceguera Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Cecite Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Llorona Blindheit";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Cecita Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Cegueira Llorona";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- ロロナの盲目";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 로로나 실명";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 洛罗纳失明";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Слепота Ллорона";
    }
}
if(c2 == 17)
{
    if(ef2 == false)
    {
        dt.gua -= 1;
        dt.tam -= 1;
        dt.ench -= 1;
        dt.frij -= 1;
        dt.ques -= 1;
        dt.nach -= 1;
        dt.burr -= 1;
        dt.taco -= 1;
        ef2 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto2.color = rojoNeon;
    textoj2.color = rojoNeon;
    textok2.color = rojoNeon;
    textoc2.color = rojoNeon;
    textor2.color = rojoNeon;
    im2.sprite = XV;

    if(idioma == "ingles")
    {
        texto2.text = "- Everything";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "- Todo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "- Tout";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "- Alles";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "- Tutto";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "- Tudo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "- すべて";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "- 모든 것";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "- 一切";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "- Всё";
    }
}
if(c2 == 22)
{
    Color rojoNeon = new Color(1f, 0f, 0f);

    texto2.color = rojoNeon;
    textoj2.color = rojoNeon;
    textok2.color = rojoNeon;
    textoc2.color = rojoNeon;
    textor2.color = rojoNeon;
    im2.sprite = XIII;

    if(idioma == "ingles")
    {
        texto2.text = "+ Death";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "+ Muerte";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "+ Mort";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "+ Tod";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "+ Morte";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "+ Morte";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "+ 死";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "+ 죽음";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "+ 死亡";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "+ Смерть";
    }
}




//CARD3
if(c3 == 1)
{
    Color verdeChillon = new Color(0f, 1f, 0f);

    texto3.color = verdeChillon;
    textoj3.color = verdeChillon;
    textok3.color = verdeChillon;
    textoc3.color = verdeChillon;
    textor3.color = verdeChillon;
    im3.sprite = O;

    if(idioma == "ingles")
    {
        texto3.text = "+ Nothing";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Nada";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Rien";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Nichts";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Niente";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Nada";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ 何もない";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 아무것도";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 没有东西";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Ничего";
    }
}
if(c3 == 2)
{
    if(ef3 == false)
    {
        dt.taco += 1;
        ef3 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto3.color = moradoNeon;
    textoj3.color = moradoNeon;
    textok3.color = moradoNeon;
    textoc3.color = moradoNeon;
    textor3.color = moradoNeon;
    im3.sprite = I;

    if(idioma == "ingles")
    {
        texto3.text = "+ Speed";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Velocidad";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Vitesse";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Geschwindigkeit";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Velocita";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Velocidade";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ スピード";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 속도";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 速度";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Скорость";
    }
}
if(c3 == 3)
{
    if(ef3 == false)
    {
        dt.burr += 1;
        ef3 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto3.color = azulNeon;
    textoj3.color = azulNeon;
    textok3.color = azulNeon;
    textoc3.color = azulNeon;
    textor3.color = azulNeon;
    im3.sprite = II;

    if(idioma == "ingles")
    {
        texto3.text = "+ Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Resistencia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Endurance";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Ausdauer";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Resistenza";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Resistencia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ スタミナ";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 스태미나";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 耐力";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Выносливость";
    }
}
if(c3 == 4)
{
    if(ef3 == false)
    {
        dt.nach += 1;
        ef3 = true;
    }

    texto3.color = new Color(1f, 0f, 0.8f);
    textoj3.color = new Color(1f, 0f, 0.8f);
    textok3.color = new Color(1f, 0f, 0.8f);
    textoc3.color = new Color(1f, 0f, 0.8f);
    textor3.color = new Color(1f, 0f, 0.8f);
    im3.sprite = III;

    if(idioma == "ingles")
    {
        texto3.text = "+ Flashlight";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Linterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Lampe de poche";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Taschenlampe";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Torcia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Lanterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ 懐中電灯";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 손전등";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 手电筒";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Фонарь";
    }
}
if(c3 == 5)
{
    if(ef3 == false)
    {
        dt.ques += 1;
        ef3 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto3.color = rosaNeon;
    textoj3.color = rosaNeon;
    textok3.color = rosaNeon;
    textoc3.color = rosaNeon;
    textor3.color = rosaNeon;
    im3.sprite = VI;

    if(idioma == "ingles")
    {
        texto3.text = "+ Stamina Recovery";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Recuperacion Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Recuperation d'endurance";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Ausdauer Wiederherstellung";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Recupero Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Recuperacao de Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ スタミナ回復";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 스태미너 회복";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 耐力恢复";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Восстановление выносливости";
    }
}
if(c3 == 6)
{
    if(ef3 == false)
    {
        dt.frij += 1;
        ef3 = true;
    }

    Color rosa = new Color(1f, 0f, 0.8f);

    texto3.color = rosa;
    textoj3.color = rosa;
    textok3.color = rosa;
    textoc3.color = rosa;
    textor3.color = rosa;
    im3.sprite = VIII;

    if(idioma == "ingles")
    {
        texto3.text = "+ Flashlight Range";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Alcance Linterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Portee de la lampe de poche";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Taschenlampenreichweite";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Raggio Torcia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Alcance da Lanterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ 懐中電灯の範囲";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 손전등 범위";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 手电筒射程";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Дальность фонаря";
    }
}
if(c3 == 7)
{
    if(ef3 == false)
    {
        dt.ench += 1;
        ef3 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto3.color = azulNeon;
    textoj3.color = azulNeon;
    textok3.color = azulNeon;
    textoc3.color = azulNeon;
    textor3.color = azulNeon;
    im3.sprite = X;

    if(idioma == "ingles")
    {
        texto3.text = "+ Microphone Silence";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Silencio Microfono";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Silencieux du Microphone";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Mikrofon Stummschalten";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Microfono Silenzio";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Silencio Microfone";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ マイクミュート";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 마이크 음소거";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 麦克风静音";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Выключить микрофон";
    }
}

if(c3 == 8)
{
    if(ef3 == false)
    {
        dt.tam += 1;
        ef3 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto3.color = verdeChillon;
    textoj3.color = verdeChillon;
    textok3.color = verdeChillon;
    textoc3.color = verdeChillon;
    textor3.color = verdeChillon;
    im3.sprite = XI;

    if(idioma == "ingles")
    {
        texto3.text = "+ Step Silence";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Silencio Pasos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Silencieux des pas";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Schrittgerauschlos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Silenzio Passi";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Silencio Passos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ 足音を消す";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 발소리 감추기";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 步伐静音";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Бесшумные шаги";
    }
}
if(c3 == 9)
{
    if(ef3 == false)
    {
        dt.gua += 1;
        ef3 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto3.color = naranjaNeon;
    textoj3.color = naranjaNeon;
    textok3.color = naranjaNeon;
    textoc3.color = naranjaNeon;
    textor3.color = naranjaNeon;
    im3.sprite = XIV;

    if(idioma == "ingles")
    {
        texto3.text = "+ Llorona Blindness";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Ceguera Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Cecite Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Llorona Blindheit";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Cecita Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Cegueira Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ ロロナの盲目";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 로로나 실명";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 洛罗纳失明";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Слепота Ллорона";
    }
}

if(c3 == 10)
{
    if(ef3 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef3 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto3.color = azulNeon;
    textoj3.color = azulNeon;
    textok3.color = azulNeon;
    textoc3.color = azulNeon;
    textor3.color = azulNeon;
    im3.sprite = XVII;

    if(idioma == "ingles")
    {
        texto3.text = "+ Stamina / Stamina Recovery";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Stamina / Recuperacion Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Endurance / Recuperation d'endurance";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Ausdauer / Ausdauer Wiederherstellung";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Stamina / Recupero Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Stamina / Recuperacao de Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ スタミナ / スタミナ回復";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 스태미너 / 스태미너 회복";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 耐力 / 耐力恢复";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Выносливость / Восстановление выносливости";
    }
}
if(c3 == 11)
{
    if(ef3 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef3 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto3.color = naranjaNeon;
    textoj3.color = naranjaNeon;
    textok3.color = naranjaNeon;
    textoc3.color = naranjaNeon;
    textor3.color = naranjaNeon;
    im3.sprite = XIX;

    if(idioma == "ingles")
    {
        texto3.text = "+ Microphone Silence / Step Silence";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Silencio Microfono / Silencio Pasos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Silence Micro / Silencieux des pas";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Mikrofon Stille / Schrittgerauschlos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Silenzio Microfono / Silenzio Passi";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Silencio Microfone / Silencio Passos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ マイク消音 / 足音を消す";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 마이크 음소거 / 발소리 감추기";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 麦克风静音 / 步伐静音";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Отключение микрофона / Бесшумные шаги";
    }
}
if(c3 == 12)
{
    if(ef3 == false)
    {
        dt.gua += 1;
        dt.tam += 1;
        dt.ench += 1;
        dt.frij += 1;
        dt.ques += 1;
        dt.nach += 1;
        dt.burr += 1;
        dt.taco += 1;
        ef3 = true;
    }

    hue += Time.deltaTime * 0.5f;
    if(hue > 1) hue = 0;

    Color color = Color.HSVToRGB(hue, 1, 1);
    texto3.color = color;
    textoj3.color = color;
    textok3.color = color;
    textoc3.color = color;
    textor3.color = color;
    im3.sprite = XXI;

    if(idioma == "ingles")
    {
        texto3.text = "+ Everything";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Todo";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Tout";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Alles";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Tutto";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Tudo";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ すべて";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 모든 것";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 一切";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Всё";
    }
}

if(c3 == 21)
{
    if(ef3 == false)
    {
        dt.nach -= 1;
        ef3 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto3.color = rojoNeon;
    textoj3.color = rojoNeon;
    textok3.color = rojoNeon;
    textoc3.color = rojoNeon;
    textor3.color = rojoNeon;
    im3.sprite = IV;

    if(idioma == "ingles")
    {
        texto3.text = "- Flashlight";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Linterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Lampe de poche";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Taschenlampe";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Torcia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Lanterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- 懐中電灯";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 손전등";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 手电筒";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Фонарь";
    }
}

if(c3 == 13)
{
    if(ef3 == false)
    {
        dt.taco -= 1;
        ef3 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto3.color = verdeChillon;
    textoj3.color = verdeChillon;
    textok3.color = verdeChillon;
    textoc3.color = verdeChillon;
    textor3.color = verdeChillon;
    im3.sprite = V;

    if(idioma == "ingles")
    {
        texto3.text = "- Speed";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Velocidad";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Vitesse";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Geschwindigkeit";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Velocita";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Velocidade";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- スピード";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 속도";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 速度";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Скорость";
    }
}
if(c3 == 14)
{
    if(ef3 == false)
    {
        dt.burr -= 1;
        ef3 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto3.color = naranjaNeon;
    textoj3.color = naranjaNeon;
    textok3.color = naranjaNeon;
    textoc3.color = naranjaNeon;
    textor3.color = naranjaNeon;
    im3.sprite = VII;

    if(idioma == "ingles")
    {
        texto3.text = "- Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Resistencia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Endurance";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Ausdauer";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Resistenza";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Resistencia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- スタミナ";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 스태미나";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 耐力";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Выносливость";
    }
}
if(c3 == 15)
{
    if(ef3 == false)
    {
        dt.ques -= 1;
        ef3 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto3.color = moradoNeon;
    textoj3.color = moradoNeon;
    textok3.color = moradoNeon;
    textoc3.color = moradoNeon;
    textor3.color = moradoNeon;
    im3.sprite = IX;

    if(idioma == "ingles")
    {
        texto3.text = "- Stamina Recovery";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Recuperacion Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Recuperation d'endurance";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Ausdauer Wiederherstellung";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Recupero Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Recuperacao de Stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- スタミナ回復";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 스태미너 회복";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 耐力恢复";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Восстановление выносливости";
    }
}
if(c3 == 16)
{
    if(ef3 == false)
    {
        dt.frij -= 1;
        ef3 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto3.color = rosaNeon;
    textoj3.color = rosaNeon;
    textok3.color = rosaNeon;
    textoc3.color = rosaNeon;
    textor3.color = rosaNeon;
    im3.sprite = XII;

    if(idioma == "ingles")
    {
        texto3.text = "- Flashlight Range";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Alcance Linterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Portee de la lampe de poche";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Taschenlampenreichweite";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Raggio Torcia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Alcance da Lanterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- 懐中電灯の範囲";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 손전등 범위";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 手电筒射程";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Дальность фонаря";
    }
}
if(c3 == 18)
{
    if(ef3 == false)
    {
        dt.ench -= 1;
        ef3 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto3.color = moradoNeon;
    textoj3.color = moradoNeon;
    textok3.color = moradoNeon;
    textoc3.color = moradoNeon;
    textor3.color = moradoNeon;
    im3.sprite = XVI;

    if(idioma == "ingles")
    {
        texto3.text = "- Microphone Silence";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Silencio Microfono";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Silencieux du Microphone";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Mikrofon Stummschalten";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Microfono Silenzio";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Silencio Microfone";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- マイクミュート";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 마이크 음소거";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 麦克风静音";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Выключить микрофон";
    }
}
if(c3 == 19)
{
    if(ef3 == false)
    {
        dt.tam -= 1;
        ef3 = true;
    }

    texto3.color = new Color(1f, 0f, 0.8f);
    textoj3.color = new Color(1f, 0f, 0.8f);
    textok3.color = new Color(1f, 0f, 0.8f);
    textoc3.color = new Color(1f, 0f, 0.8f);
    textor3.color = new Color(1f, 0f, 0.8f);
    im3.sprite = XVIII;

    if(idioma == "ingles")
    {
        texto3.text = "- Step Silence";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Silencio Pasos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Silencieux des pas";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Schrittgerauschlos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Silenzio Passi";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Silencio Passos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- 足音を消す";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 발소리 감추기";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 步伐静音";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Бесшумные шаги";
    }
}

if(c3 == 20)
{
    if(ef3 == false)
    {
        dt.gua -= 1;
        ef3 = true;
    }

    texto3.color = new Color(1f, 0f, 0.8f);
    textoj3.color = new Color(1f, 0f, 0.8f);
    textok3.color = new Color(1f, 0f, 0.8f);
    textoc3.color = new Color(1f, 0f, 0.8f);
    textor3.color = new Color(1f, 0f, 0.8f);
    im3.sprite = XX;

    if(idioma == "ingles")
    {
        texto3.text = "- Llorona Blindness";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Ceguera Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Cecite Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Llorona Blindheit";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Cecita Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Cegueira Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- ロロナの盲目";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 로로나 실명";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 洛罗纳失明";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Слепота Ллорона";
    }
}
if(c3 == 17)
{
    if(ef3 == false)
    {
        dt.gua -= 1;
        dt.tam -= 1;
        dt.ench -= 1;
        dt.frij -= 1;
        dt.ques -= 1;
        dt.nach -= 1;
        dt.burr -= 1;
        dt.taco -= 1;
        ef3 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto3.color = rojoNeon;
    textoj3.color = rojoNeon;
    textok3.color = rojoNeon;
    textoc3.color = rojoNeon;
    textor3.color = rojoNeon;
    im3.sprite = XV;

    if(idioma == "ingles")
    {
        texto3.text = "- Everything";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "- Todo";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "- Tout";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "- Alles";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "- Tutto";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "- Tudo";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "- すべて";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "- 모든 것";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "- 一切";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "- Всё";
    }
}
if(c3 == 22)
{
    Color rojoNeon = new Color(1f, 0f, 0f);

    texto3.color = rojoNeon;
    textoj3.color = rojoNeon;
    textok3.color = rojoNeon;
    textoc3.color = rojoNeon;
    textor3.color = rojoNeon;
    im3.sprite = XIII;

    if(idioma == "ingles")
    {
        texto3.text = "+ Death";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "+ Muerte";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "+ Mort";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "+ Tod";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "+ Morte";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "+ Morte";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "+ 死";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "+ 죽음";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "+ 死亡";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "+ Смерть";
    }
}




//CARD5
if(c5 == 1)
{
    Color verdeChillon = new Color(0f, 1f, 0f);

    texto5.color = verdeChillon;
    textoj5.color = verdeChillon;
    textok5.color = verdeChillon;
    textoc5.color = verdeChillon;
    textor5.color = verdeChillon;
    im5.sprite = O;

    if(idioma == "ingles")
    {
        texto5.text = "+ Nothing";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "español")
    {
        texto5.text = "+ Nada";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "frances")
    {
        texto5.text = "+ Rien";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "aleman")
    {
        texto5.text = "+ Nichts";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "italiano")
    {
        texto5.text = "+ Niente";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "portugues")
    {
        texto5.text = "+ Nada";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "japones")
    {
        texto5.text = "";
        textoj5.text = "+ 何もない";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "coreano")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "+ 아무것도";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "chino")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "+ 没有东西";
        textor5.text = "";
    }
    if(idioma == "ruso")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "+ Ничего";
    }
}
if(c5 == 2)
{
    if(ef5 == false)
    {
        dt.taco += 1;
        ef5 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto5.color = moradoNeon;
    textoj5.color = moradoNeon;
    textok5.color = moradoNeon;
    textoc5.color = moradoNeon;
    textor5.color = moradoNeon;
    im5.sprite = I;

    if(idioma == "ingles")
    {
        texto5.text = "+ Speed";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "español")
    {
        texto5.text = "+ Velocidad";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "frances")
    {
        texto5.text = "+ Vitesse";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "aleman")
    {
        texto5.text = "+ Geschwindigkeit";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "italiano")
    {
        texto5.text = "+ Velocita";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "portugues")
    {
        texto5.text = "+ Velocidade";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "japones")
    {
        texto5.text = "";
        textoj5.text = "+ スピード";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "coreano")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "+ 속도";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "chino")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "+ 速度";
        textor5.text = "";
    }
    if(idioma == "ruso")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "+ Скорость";
    }
}
if(c5 == 3)
{
    if(ef5 == false)
    {
        dt.burr += 1;
        ef5 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto5.color = azulNeon;
    textoj5.color = azulNeon;
    textok5.color = azulNeon;
    textoc5.color = azulNeon;
    textor5.color = azulNeon;
    im5.sprite = II;

    if(idioma == "ingles")
    {
        texto5.text = "+ Stamina";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "español")
    {
        texto5.text = "+ Resistencia";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "frances")
    {
        texto5.text = "+ Endurance";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "aleman")
    {
        texto5.text = "+ Ausdauer";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "italiano")
    {
        texto5.text = "+ Resistenza";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "portugues")
    {
        texto5.text = "+ Resistencia";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "japones")
    {
        texto5.text = "";
        textoj5.text = "+ スタミナ";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "coreano")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "+ 스태미나";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "chino")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "+ 耐力";
        textor5.text = "";
    }
    if(idioma == "ruso")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "+ Выносливость";
    }
}

if(c5 == 4)
{
    if(ef5 == false)
    {
        dt.nach += 1;
        ef5 = true;
    }

    texto5.color = new Color(1f, 0f, 0.8f);
    textoj5.color = new Color(1f, 0f, 0.8f);
    textok5.color = new Color(1f, 0f, 0.8f);
    textoc5.color = new Color(1f, 0f, 0.8f);
    textor5.color = new Color(1f, 0f, 0.8f);
    im5.sprite = III;

    if(idioma == "ingles")
    {
        texto5.text = "+ Flashlight";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "español")
    {
        texto5.text = "+ Linterna";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "frances")
    {
        texto5.text = "+ Lampe de poche";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "aleman")
    {
        texto5.text = "+ Taschenlampe";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "italiano")
    {
        texto5.text = "+ Torcia";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "portugues")
    {
        texto5.text = "+ Lanterna";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "japones")
    {
        texto5.text = "";
        textoj5.text = "+ 懐中電灯";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "coreano")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "+ 손전등";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "chino")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "+ 手电筒";
        textor5.text = "";
    }
    if(idioma == "ruso")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "+ Фонарь";
    }
}
if(c5 == 5)
{
    if(ef5 == false)
    {
        dt.ques += 1;
        ef5 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto5.color = rosaNeon;
    textoj5.color = rosaNeon;
    textok5.color = rosaNeon;
    textoc5.color = rosaNeon;
    textor5.color = rosaNeon;
    im5.sprite = VI;

    if(idioma == "ingles")
    {
        texto5.text = "+ Stamina Recovery";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "español")
    {
        texto5.text = "+ Recuperacion Stamina";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "frances")
    {
        texto5.text = "+ Recuperation d'endurance";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "aleman")
    {
        texto5.text = "+ Ausdauer Wiederherstellung";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "italiano")
    {
        texto5.text = "+ Recupero Stamina";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "portugues")
    {
        texto5.text = "+ Recuperacao de Stamina";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "japones")
    {
        texto5.text = "";
        textoj5.text = "+ スタミナ回復";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "coreano")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "+ 스태미너 회복";
        textoc5.text = "";
        textor5.text = "";
    }
    if(idioma == "chino")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "+ 耐力恢复";
        textor5.text = "";
    }
    if(idioma == "ruso")
    {
        texto5.text = "";
        textoj5.text = "";
        textok5.text = "";
        textoc5.text = "";
        textor5.text = "+ Восстановление выносливости";
    }
}
if(c5 == 6)
{
    if(ef5 == false)
    {
        dt.frij += 1;
        ef5 = true;
    }

    Color rosa = new Color(1f, 0f, 0.8f);

    texto5.color = rosa;
    textoj5.color = rosa;
    textok5.color = rosa;
    textoc5.color = rosa;
    textor5.color = rosa;
    im5.sprite = VIII;

    if(idioma == "ingles") { texto5.text = "+ Flashlight Range"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Alcance Linterna"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Portee de la lampe de poche"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Taschenlampenreichweite"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Raggio Torcia"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Alcance da Lanterna"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ 懐中電灯の範囲"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 손전등 범위"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 手电筒射程"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Дальность фонаря"; }
}
if(c5 == 7)
{
    if(ef5 == false)
    {
        dt.ench += 1;
        ef5 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto5.color = azulNeon;
    textoj5.color = azulNeon;
    textok5.color = azulNeon;
    textoc5.color = azulNeon;
    textor5.color = azulNeon;
    im5.sprite = X;

    if(idioma == "ingles") { texto5.text = "+ Microphone Silence"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Silencio Microfono"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Silencieux du Microphone"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Mikrofon Stummschalten"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Microfono Silenzio"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Silencio Microfone"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ マイクミュート"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 마이크 음소거"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 麦克风静音"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Выключить микрофон"; }
}
if(c5 == 8)
{
    if(ef5 == false)
    {
        dt.tam += 1;
        ef5 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto5.color = verdeChillon;
    textoj5.color = verdeChillon;
    textok5.color = verdeChillon;
    textoc5.color = verdeChillon;
    textor5.color = verdeChillon;
    im5.sprite = XI;

    if(idioma == "ingles") { texto5.text = "+ Step Silence"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Silencio Pasos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Silencieux des pas"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Schrittgerauschlos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Silenzio Passi"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Silencio Passos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ 足音を消す"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 발소리 감추기"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 步伐静音"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Бесшумные шаги"; }
}
if(c5 == 9)
{
    if(ef5 == false)
    {
        dt.gua += 1;
        ef5 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto5.color = naranjaNeon;
    textoj5.color = naranjaNeon;
    textok5.color = naranjaNeon;
    textoc5.color = naranjaNeon;
    textor5.color = naranjaNeon;
    im5.sprite = XIV;

    if(idioma == "ingles") { texto5.text = "+ Llorona Blindness"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Ceguera Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Cecite Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Llorona Blindheit"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Cecita Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Cegueira Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ ロロナの盲目"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 로로나 실명"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 洛罗纳失明"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Слепота Ллорона"; }
}
if(c5 == 10)
{
    if(ef5 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef5 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto5.color = azulNeon;
    textoj5.color = azulNeon;
    textok5.color = azulNeon;
    textoc5.color = azulNeon;
    textor5.color = azulNeon;
    im5.sprite = XVII;

    if(idioma == "ingles") { texto5.text = "+ Stamina / Stamina Recovery"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Stamina / Recuperacion Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Endurance / Recuperation d'endurance"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Ausdauer / Ausdauer Wiederherstellung"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Stamina / Recupero Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Stamina / Recuperacao de Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ スタミナ / スタミナ回復"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 스태미너 / 스태미너 회복"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 耐力 / 耐力恢复"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Выносливость / Восстановление выносливости"; }
}
if(c5 == 11)
{
    if(ef5 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef5 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto5.color = naranjaNeon;
    textoj5.color = naranjaNeon;
    textok5.color = naranjaNeon;
    textoc5.color = naranjaNeon;
    textor5.color = naranjaNeon;
    im5.sprite = XIX;

    if(idioma == "ingles") { texto5.text = "+ Microphone Silence / Step Silence"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Silencio Microfono / Silencio Pasos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Silence Micro / Silencieux des pas"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Mikrofon Stille / Schrittgerauschlos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Silenzio Microfono / Silenzio Passi"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Silencio Microfone / Silencio Passos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ マイク消音 / 足音を消す"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 마이크 음소거 / 발소리 감추기"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 麦克风静音 / 步伐静音"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Отключение микрофона / Бесшумные шаги"; }
}
if(c5 == 12)
{
    if(ef5 == false)
    {
        dt.gua += 1;
        dt.tam += 1;
        dt.ench += 1;
        dt.frij += 1;
        dt.ques += 1;
        dt.nach += 1;
        dt.burr += 1;
        dt.taco += 1;
        ef5 = true;
    }

    hue += Time.deltaTime * 0.5f;
    if(hue > 1) hue = 0;

    Color color = Color.HSVToRGB(hue, 1, 1);
    texto5.color = color;
    textoj5.color = color;
    textok5.color = color;
    textoc5.color = color;
    textor5.color = color;
    im5.sprite = XXI;

    if(idioma == "ingles") { texto5.text = "+ Everything"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Todo"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Tout"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Alles"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Tutto"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Tudo"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ すべて"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 모든 것"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 一切"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Всё"; }
}

if(c5 == 21)
{
    if(ef5 == false)
    {
        dt.nach -= 1;
        ef5 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto5.color = rojoNeon;
    textoj5.color = rojoNeon;
    textok5.color = rojoNeon;
    textoc5.color = rojoNeon;
    textor5.color = rojoNeon;
    im5.sprite = IV;

    if(idioma == "ingles") { texto5.text = "- Flashlight"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Linterna"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Lampe de poche"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Taschenlampe"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Torcia"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Lanterna"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- 懐中電灯"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 손전등"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 手电筒"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Фонарь"; }
}
if(c5 == 13)
{
    if(ef5 == false)
    {
        dt.taco -= 1;
        ef5 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto5.color = verdeChillon;
    textoj5.color = verdeChillon;
    textok5.color = verdeChillon;
    textoc5.color = verdeChillon;
    textor5.color = verdeChillon;
    im5.sprite = V;

    if(idioma == "ingles") { texto5.text = "- Speed"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Velocidad"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Vitesse"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Geschwindigkeit"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Velocita"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Velocidade"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- スピード"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 속도"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 速度"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Скорость"; }
}
if(c5 == 14)
{
    if(ef5 == false)
    {
        dt.burr -= 1;
        ef5 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto5.color = naranjaNeon;
    textoj5.color = naranjaNeon;
    textok5.color = naranjaNeon;
    textoc5.color = naranjaNeon;
    textor5.color = naranjaNeon;
    im5.sprite = VII;

    if(idioma == "ingles") { texto5.text = "- Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Resistencia"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Endurance"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Ausdauer"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Resistenza"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Resistencia"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- スタミナ"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 스태미나"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 耐力"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Выносливость"; }
}
if(c5 == 15)
{
    if(ef5 == false)
    {
        dt.ques -= 1;
        ef5 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto5.color = moradoNeon;
    textoj5.color = moradoNeon;
    textok5.color = moradoNeon;
    textoc5.color = moradoNeon;
    textor5.color = moradoNeon;
    im5.sprite = IX;

    if(idioma == "ingles") { texto5.text = "- Stamina Recovery"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Recuperacion Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Recuperation d'endurance"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Ausdauer Wiederherstellung"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Recupero Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Recuperacao de Stamina"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- スタミナ回復"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 스태미너 회복"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 耐力恢复"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Восстановление выносливости"; }
}
if(c5 == 16)
{
    if(ef5 == false)
    {
        dt.frij -= 1;
        ef5 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto5.color = rosaNeon;
    textoj5.color = rosaNeon;
    textok5.color = rosaNeon;
    textoc5.color = rosaNeon;
    textor5.color = rosaNeon;
    im5.sprite = XII;

    if(idioma == "ingles") { texto5.text = "- Flashlight Range"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Alcance Linterna"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Portee de la lampe de poche"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Taschenlampenreichweite"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Raggio Torcia"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Alcance da Lanterna"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- 懐中電灯の範囲"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 손전등 범위"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 手电筒射程"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Дальность фонаря"; }
}
if(c5 == 18)
{
    if(ef5 == false)
    {
        dt.ench -= 1;
        ef5 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto5.color = moradoNeon;
    textoj5.color = moradoNeon;
    textok5.color = moradoNeon;
    textoc5.color = moradoNeon;
    textor5.color = moradoNeon;
    im5.sprite = XVI;

    if(idioma == "ingles") { texto5.text = "- Microphone Silence"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Silencio Microfono"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Silencieux du Microphone"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Mikrofon Stummschalten"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Microfono Silenzio"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Silencio Microfone"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- マイクミュート"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 마이크 음소거"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 麦克风静音"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Выключить микрофон"; }
}
if(c5 == 19)
{
    if(ef5 == false)
    {
        dt.tam -= 1;
        ef5 = true;
    }

    Color rosaNeon = new Color(1f, 0f, 0.8f);

    texto5.color = rosaNeon;
    textoj5.color = rosaNeon;
    textok5.color = rosaNeon;
    textoc5.color = rosaNeon;
    textor5.color = rosaNeon;
    im5.sprite = XVIII;

    if(idioma == "ingles") { texto5.text = "- Step Silence"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Silencio Pasos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Silencieux des pas"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Schrittgerauschlos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Silenzio Passi"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Silencio Passos"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- 足音を消す"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 발소리 감추기"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 步伐静音"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Бесшумные шаги"; }
}

if(c5 == 20)
{
    if(ef5 == false)
    {
        dt.gua -= 1;
        ef5 = true;
    }

    Color rosaNeon = new Color(1f, 0f, 0.8f);

    texto5.color = rosaNeon;
    textoj5.color = rosaNeon;
    textok5.color = rosaNeon;
    textoc5.color = rosaNeon;
    textor5.color = rosaNeon;
    im5.sprite = XX;

    if(idioma == "ingles") { texto5.text = "- Llorona Blindness"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Ceguera Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Cecite Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Llorona Blindheit"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Cecita Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Cegueira Llorona"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- ロロナの盲目"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 로로나 실명"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 洛罗纳失明"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Слепота Ллорона"; }
}
if(c5 == 17)
{
    if(ef5 == false)
    {
        dt.gua -= 1;
        dt.tam -= 1;
        dt.ench -= 1;
        dt.frij -= 1;
        dt.ques -= 1;
        dt.nach -= 1;
        dt.burr -= 1;
        dt.taco -= 1;
        ef5 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto5.color = rojoNeon;
    textoj5.color = rojoNeon;
    textok5.color = rojoNeon;
    textoc5.color = rojoNeon;
    textor5.color = rojoNeon;
    im5.sprite = XV;

    if(idioma == "ingles") { texto5.text = "- Everything"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "- Todo"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "- Tout"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "- Alles"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "- Tutto"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "- Tudo"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "- すべて"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "- 모든 것"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "- 一切"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "- Всё"; }
}
if(c5 == 22)
{
    Color rojoNeon = new Color(1f, 0f, 0f);

    texto5.color = rojoNeon;
    textoj5.color = rojoNeon;
    textok5.color = rojoNeon;
    textoc5.color = rojoNeon;
    textor5.color = rojoNeon;
    im5.sprite = XIII;

    if(idioma == "ingles") { texto5.text = "+ Death"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "español") { texto5.text = "+ Muerte"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "frances") { texto5.text = "+ Mort"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "aleman") { texto5.text = "+ Tod"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "italiano") { texto5.text = "+ Morte"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "portugues") { texto5.text = "+ Morte"; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "japones") { texto5.text = ""; textoj5.text = "+ 死"; textok5.text = ""; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "coreano") { texto5.text = ""; textoj5.text = ""; textok5.text = "+ 죽음"; textoc5.text = ""; textor5.text = ""; }
    if(idioma == "chino") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = "+ 死亡"; textor5.text = ""; }
    if(idioma == "ruso") { texto5.text = ""; textoj5.text = ""; textok5.text = ""; textoc5.text = ""; textor5.text = "+ Смерть"; }
}
//CARD4
if(c4 == 1)
{
    Color verdeChillon = new Color(0f, 1f, 0f);

    texto4.color = verdeChillon;
    textoj4.color = verdeChillon;
    textok4.color = verdeChillon;
    textoc4.color = verdeChillon;
    textor4.color = verdeChillon;
    im4.sprite = O;

    if(idioma == "ingles")
    {
        texto4.text = "+ Nothing";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Nada";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Rien";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Nichts";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Niente";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Nada";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ 何もない";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 아무것도";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 没有东西";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Ничего";
    }
}
if(c4 == 2)
{
    if(ef4 == false)
    {
        dt.taco += 1;
        ef4 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto4.color = moradoNeon;
    textoj4.color = moradoNeon;
    textok4.color = moradoNeon;
    textoc4.color = moradoNeon;
    textor4.color = moradoNeon;
    im4.sprite = I;

    if(idioma == "ingles")
    {
        texto4.text = "+ Speed";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Velocidad";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Vitesse";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Geschwindigkeit";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Velocita";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Velocidade";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ スピード";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 속도";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 速度";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Скорость";
    }
}
if(c4 == 3)
{
    if(ef4 == false)
    {
        dt.burr += 1;
        ef4 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto4.color = azulNeon;
    textoj4.color = azulNeon;
    textok4.color = azulNeon;
    textoc4.color = azulNeon;
    textor4.color = azulNeon;
    im4.sprite = II;

    if(idioma == "ingles")
    {
        texto4.text = "+ Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Resistencia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Endurance";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Ausdauer";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Resistenza";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Resistencia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ スタミナ";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 스태미나";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 耐力";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Выносливость";
    }
}

if(c4 == 4)
{
    if(ef4 == false)
    {
        dt.nach += 1;
        ef4 = true;
    }

    texto4.color = new Color(1f, 0f, 0.8f);
    textoj4.color = new Color(1f, 0f, 0.8f);
    textok4.color = new Color(1f, 0f, 0.8f);
    textoc4.color = new Color(1f, 0f, 0.8f);
    textor4.color = new Color(1f, 0f, 0.8f);
    im4.sprite = III;

    if(idioma == "ingles")
    {
        texto4.text = "+ Flashlight";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Linterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Lampe de poche";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Taschenlampe";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Torcia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Lanterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ 懐中電灯";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 손전등";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 手电筒";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Фонарь";
    }
}
if(c4 == 5)
{
    if(ef4 == false)
    {
        dt.ques += 1;
        ef4 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto4.color = rosaNeon;
    textoj4.color = rosaNeon;
    textok4.color = rosaNeon;
    textoc4.color = rosaNeon;
    textor4.color = rosaNeon;
    im4.sprite = VI;

    if(idioma == "ingles")
    {
        texto4.text = "+ Stamina Recovery";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Recuperacion Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Recuperation d'endurance";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Ausdauer Wiederherstellung";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Recupero Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Recuperacao de Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ スタミナ回復";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 스태미너 회복";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 耐力恢复";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Восстановление выносливости";
    }
}
if(c4 == 6)
{
    if(ef4 == false)
    {
        dt.frij += 1;
        ef4 = true;
    }

    Color rosa = new Color(1f, 0f, 0.8f);

    texto4.color = rosa;
    textoj4.color = rosa;
    textok4.color = rosa;
    textoc4.color = rosa;
    textor4.color = rosa;
    im4.sprite = VIII;

    if(idioma == "ingles")
    {
        texto4.text = "+ Flashlight Range";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Alcance Linterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Portee de la lampe de poche";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Taschenlampenreichweite";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Raggio Torcia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Alcance da Lanterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ 懐中電灯の範囲";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 손전등 범위";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 手电筒射程";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Дальность фонаря";
    }
}
if(c4 == 7)
{
    if(ef4 == false)
    {
        dt.ench += 1;
        ef4 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto4.color = azulNeon;
    textoj4.color = azulNeon;
    textok4.color = azulNeon;
    textoc4.color = azulNeon;
    textor4.color = azulNeon;
    im4.sprite = X;

    if(idioma == "ingles")
    {
        texto4.text = "+ Microphone Silence";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Silencio Microfono";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Silencieux du Microphone";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Mikrofon Stummschalten";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Microfono Silenzio";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Silencio Microfone";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ マイクミュート";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 마이크 음소거";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 麦克风静音";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Выключить микрофон";
    }
}
if(c4 == 8)
{
    if(ef4 == false)
    {
        dt.tam += 1;
        ef4 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto4.color = verdeChillon;
    textoj4.color = verdeChillon;
    textok4.color = verdeChillon;
    textoc4.color = verdeChillon;
    textor4.color = verdeChillon;
    im4.sprite = XI;

    if(idioma == "ingles")
    {
        texto4.text = "+ Step Silence";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Silencio Pasos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Silencieux des pas";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Schrittgerauschlos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Silenzio Passi";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Silencio Passos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ 足音を消す";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 발소리 감추기";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 步伐静音";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Бесшумные шаги";
    }
}
if(c4 == 9)
{
    if(ef4 == false)
    {
        dt.gua += 1;
        ef4 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto4.color = naranjaNeon;
    textoj4.color = naranjaNeon;
    textok4.color = naranjaNeon;
    textoc4.color = naranjaNeon;
    textor4.color = naranjaNeon;
    im4.sprite = XIV;

    if(idioma == "ingles")
    {
        texto4.text = "+ Llorona Blindness";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Ceguera Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Cecite Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Llorona Blindheit";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Cecita Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Cegueira Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ ロロナの盲目";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 로로나 실명";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 洛罗纳失明";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Слепота Ллорона";
    }
}
if(c4 == 10)
{
    if(ef4 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef4 = true;
    }

    Color azulNeon = new Color(0f, 0.8f, 1f);

    texto4.color = azulNeon;
    textoj4.color = azulNeon;
    textok4.color = azulNeon;
    textoc4.color = azulNeon;
    textor4.color = azulNeon;
    im4.sprite = XVII;

    if(idioma == "ingles")
    {
        texto4.text = "+ Stamina / Stamina Recovery";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Stamina / Recuperacion Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Endurance / Recuperation d'endurance";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Ausdauer / Ausdauer Wiederherstellung";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Stamina / Recupero Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Stamina / Recuperacao de Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ スタミナ / スタミナ回復";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 스태미너 / 스태미너 회복";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 耐力 / 耐力恢复";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Выносливость / Восстановление выносливости";
    }
}
if(c4 == 11)
{
    if(ef4 == false)
    {
        dt.ques += 1;
        dt.nach += 1;
        ef4 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto4.color = naranjaNeon;
    textoj4.color = naranjaNeon;
    textok4.color = naranjaNeon;
    textoc4.color = naranjaNeon;
    textor4.color = naranjaNeon;
    im4.sprite = XIX;

    if(idioma == "ingles")
    {
        texto4.text = "+ Microphone Silence / Step Silence";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Silencio Microfono / Silencio Pasos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Silence Micro / Silencieux des pas";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Mikrofon Stille / Schrittgerauschlos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Silenzio Microfono / Silenzio Passi";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Silencio Microfone / Silencio Passos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ マイク消音 / 足音を消す";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 마이크 음소거 / 발소리 감추기";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 麦克风静音 / 步伐静音";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Отключение микрофона / Бесшумные шаги";
    }
}
if(c4 == 12)
{
    if(ef4 == false)
    {
        dt.gua += 1;
        dt.tam += 1;
        dt.ench += 1;
        dt.frij += 1;
        dt.ques += 1;
        dt.nach += 1;
        dt.burr += 1;
        dt.taco += 1;
        ef4 = true;
    }

    hue += Time.deltaTime * 0.5f;
    if(hue > 1) hue = 0;

    Color color = Color.HSVToRGB(hue, 1, 1);
    texto4.color = color;
    textoj4.color = color;
    textok4.color = color;
    textoc4.color = color;
    textor4.color = color;
    im4.sprite = XXI;

    if(idioma == "ingles")
    {
        texto4.text = "+ Everything";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Todo";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Tout";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Alles";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Tutto";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Tudo";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ すべて";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 모든 것";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 一切";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Всё";
    }
}

if(c4 == 21)
{
    if(ef4 == false)
    {
        dt.nach -= 1;
        ef4 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto4.color = rojoNeon;
    textoj4.color = rojoNeon;
    textok4.color = rojoNeon;
    textoc4.color = rojoNeon;
    textor4.color = rojoNeon;
    im4.sprite = IV;

    if(idioma == "ingles")
    {
        texto4.text = "- Flashlight";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Linterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Lampe de poche";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Taschenlampe";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Torcia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Lanterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- 懐中電灯";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 손전등";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 手电筒";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Фонарь";
    }
}
if(c4 == 13)
{
    if(ef4 == false)
    {
        dt.taco -= 1;
        ef4 = true;
    }

    Color verdeChillon = new Color(0f, 1f, 0f);

    texto4.color = verdeChillon;
    textoj4.color = verdeChillon;
    textok4.color = verdeChillon;
    textoc4.color = verdeChillon;
    textor4.color = verdeChillon;
    im4.sprite = V;

    if(idioma == "ingles")
    {
        texto4.text = "- Speed";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Velocidad";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Vitesse";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Geschwindigkeit";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Velocita";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Velocidade";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- スピード";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 속도";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 速度";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Скорость";
    }
}
if(c4 == 14)
{
    if(ef4 == false)
    {
        dt.burr -= 1;
        ef4 = true;
    }

    Color naranjaNeon = new Color(1f, 0.5f, 0f);

    texto4.color = naranjaNeon;
    textoj4.color = naranjaNeon;
    textok4.color = naranjaNeon;
    textoc4.color = naranjaNeon;
    textor4.color = naranjaNeon;
    im4.sprite = VII;

    if(idioma == "ingles")
    {
        texto4.text = "- Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Resistencia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Endurance";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Ausdauer";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Resistenza";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Resistencia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- スタミナ";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 스태미나";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 耐力";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Выносливость";
    }
}
if(c4 == 15)
{
    if(ef4 == false)
    {
        dt.ques -= 1;
        ef4 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto4.color = moradoNeon;
    textoj4.color = moradoNeon;
    textok4.color = moradoNeon;
    textoc4.color = moradoNeon;
    textor4.color = moradoNeon;
    im4.sprite = IX;

    if(idioma == "ingles")
    {
        texto4.text = "- Stamina Recovery";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Recuperacion Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Recuperation d'endurance";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Ausdauer Wiederherstellung";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Recupero Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Recuperacao de Stamina";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- スタミナ回復";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 스태미너 회복";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 耐力恢复";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Восстановление выносливости";
    }
}
if(c4 == 16)
{
    if(ef4 == false)
    {
        dt.frij -= 1;
        ef4 = true;
    }

    Color rosaNeon = new Color(1f, 0.3f, 0.9f);

    texto4.color = rosaNeon;
    textoj4.color = rosaNeon;
    textok4.color = rosaNeon;
    textoc4.color = rosaNeon;
    textor4.color = rosaNeon;
    im4.sprite = XII;

    if(idioma == "ingles")
    {
        texto4.text = "- Flashlight Range";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Alcance Linterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Portee de la lampe de poche";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Taschenlampenreichweite";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Raggio Torcia";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Alcance da Lanterna";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- 懐中電灯の範囲";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 손전등 범위";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 手电筒射程";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Дальность фонаря";
    }
}
if(c4 == 18)
{
    if(ef4 == false)
    {
        dt.ench -= 1;
        ef4 = true;
    }

    Color moradoNeon = new Color(0.7f, 0f, 1f);

    texto4.color = moradoNeon;
    textoj4.color = moradoNeon;
    textok4.color = moradoNeon;
    textoc4.color = moradoNeon;
    textor4.color = moradoNeon;
    im4.sprite = XVI;

    if(idioma == "ingles")
    {
        texto4.text = "- Microphone Silence";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Silencio Microfono";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Silencieux du Microphone";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Mikrofon Stummschalten";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Microfono Silenzio";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Silencio Microfone";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- マイクミュート";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 마이크 음소거";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 麦克风静音";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Выключить микрофон";
    }
}
if(c4 == 19)
{
    if(ef4 == false)
    {
        dt.tam -= 1;
        ef4 = true;
    }

    texto4.color = new Color(1f, 0f, 0.8f);
    textoj4.color = new Color(1f, 0f, 0.8f);
    textok4.color = new Color(1f, 0f, 0.8f);
    textoc4.color = new Color(1f, 0f, 0.8f);
    textor4.color = new Color(1f, 0f, 0.8f);
    im4.sprite = XVIII;

    if(idioma == "ingles")
    {
        texto4.text = "- Step Silence";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Silencio Pasos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Silencieux des pas";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Schrittgerauschlos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Silenzio Passi";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Silencio Passos";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- 足音を消す";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 발소리 감추기";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 步伐静音";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Бесшумные шаги";
    }
}

if(c4 == 20)
{
    if(ef4 == false)
    {
        dt.gua -= 1;
        ef4 = true;
    }

    texto4.color = new Color(1f, 0f, 0.8f);
    textoj4.color = new Color(1f, 0f, 0.8f);
    textok4.color = new Color(1f, 0f, 0.8f);
    textoc4.color = new Color(1f, 0f, 0.8f);
    textor4.color = new Color(1f, 0f, 0.8f);
    im4.sprite = XX;

    if(idioma == "ingles")
    {
        texto4.text = "- Llorona Blindness";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Ceguera Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Cecite Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Llorona Blindheit";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Cecita Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Cegueira Llorona";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- ロロナの盲目";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 로로나 실명";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 洛罗纳失明";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Слепота Ллорона";
    }
}
if(c4 == 17)
{
    if(ef4 == false)
    {
        dt.gua -= 1;
        dt.tam -= 1;
        dt.ench -= 1;
        dt.frij -= 1;
        dt.ques -= 1;
        dt.nach -= 1;
        dt.burr -= 1;
        dt.taco -= 1;
        ef4 = true;
    }

    Color rojoNeon = new Color(1f, 0f, 0f);

    texto4.color = rojoNeon;
    textoj4.color = rojoNeon;
    textok4.color = rojoNeon;
    textoc4.color = rojoNeon;
    textor4.color = rojoNeon;
    im4.sprite = XV;

    if(idioma == "ingles")
    {
        texto4.text = "- Everything";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "- Todo";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "- Tout";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "- Alles";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "- Tutto";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "- Tudo";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "- すべて";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "- 모든 것";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "- 一切";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "- Всё";
    }
}
if(c4 == 22)
{
    Color rojoNeon = new Color(1f, 0f, 0f);

    texto4.color = rojoNeon;
    textoj4.color = rojoNeon;
    textok4.color = rojoNeon;
    textoc4.color = rojoNeon;
    textor4.color = rojoNeon;
    im4.sprite = XIII;

    if(idioma == "ingles")
    {
        texto4.text = "+ Death";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "español")
    {
        texto4.text = "+ Muerte";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "frances")
    {
        texto4.text = "+ Mort";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "aleman")
    {
        texto4.text = "+ Tod";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "italiano")
    {
        texto4.text = "+ Morte";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "portugues")
    {
        texto4.text = "+ Morte";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "japones")
    {
        texto4.text = "";
        textoj4.text = "+ 死";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "coreano")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "+ 죽음";
        textoc4.text = "";
        textor4.text = "";
    }
    if(idioma == "chino")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "+ 死亡";
        textor4.text = "";
    }
    if(idioma == "ruso")
    {
        texto4.text = "";
        textoj4.text = "";
        textok4.text = "";
        textoc4.text = "";
        textor4.text = "+ Смерть";
    }
}
        if(intering == true && freeze == false && controller.height <= 0.9 && crdd == true)
        {
if (playst == true)
{
    if (idioma == "ingles")
    {
        textox.text = "Read <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "español")
    {
        textox.text = "Leer <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "frances")
    {
        textox.text = "Lire <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "aleman")
    {
        textox.text = "Lesen <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "italiano")
    {
        textox.text = "Leggere <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "portugues")
    {
        textox.text = "Ler <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "japones")
    {
        textox.text = "";
        textojx.text = "読む <sprite name=\"pixel_art_small\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "읽다 <sprite name=\"pixel_art_small\">";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "阅读 <sprite name=\"pixel_art_small\">";
        textorx.text = "";
    }
    if (idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Читать <sprite name=\"pixel_art_small\">";
    }
}

if (xbox == true)
{
    if (idioma == "ingles")
    {
        textox.text = "Read <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "español")
    {
        textox.text = "Leer <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "frances")
    {
        textox.text = "Lire <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "aleman")
    {
        textox.text = "Lesen <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "italiano")
    {
        textox.text = "Leggere <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "portugues")
    {
        textox.text = "Ler <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "japones")
    {
        textox.text = "";
        textojx.text = "読む <sprite name=\"A\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "읽다 <sprite name=\"A\">";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "阅读 <sprite name=\"A\">";
        textorx.text = "";
    }
    if (idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Читать <sprite name=\"A\">";
    }
}

if (playst == false && xbox == false)
{
    if (idioma == "ingles")
    {
        textox.text = "Read <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "español")
    {
        textox.text = "Leer <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "frances")
    {
        textox.text = "Lire <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "aleman")
    {
        textox.text = "Lesen <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "italiano")
    {
        textox.text = "Leggere <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "portugues")
    {
        textox.text = "Ler <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "japones")
    {
        textox.text = "";
        textojx.text = "読む <sprite name=\"E\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "읽다 <sprite name=\"E\">";
        textocx.text = "";
        textorx.text = "";
    }
    if (idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "阅读 <sprite name=\"E\">";
        textorx.text = "";
    }
    if (idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Читать <sprite name=\"E\">";
    }
}
        }

        if(intering == true && freeze == false && controller.height >= 1 && crdd == false)
        {
if(playst == true)
{
if(idioma == "ingles")
{
    textox.text = "Predict the future <sprite name=\"pixel_art_small\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "español")
{
    textox.text = "Adivinar el futuro <sprite name=\"pixel_art_small\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "frances")
{
    textox.text = "Predire l’avenir <sprite name=\"pixel_art_small\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "aleman")
{
    textox.text = "Die Zukunft vorhersagen <sprite name=\"pixel_art_small\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "italiano")
{
    textox.text = "Predire il futuro <sprite name=\"pixel_art_small\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "portugues")
{
    textox.text = "Adivinhar o futuro <sprite name=\"pixel_art_small\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "japones")
{
    textox.text = "";
    textojx.text = "未来を予測する <sprite name=\"pixel_art_small\">";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "coreano")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "미래를 예측하다 <sprite name=\"pixel_art_small\">";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "chino")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "预测未来 <sprite name=\"pixel_art_small\">";
    textorx.text = "";
}
if(idioma == "ruso")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "предсказывать будущее <sprite name=\"pixel_art_small\">";
}
}

if(xbox == true)
{
if(idioma == "ingles")
{
    textox.text = "Predict the future <sprite name=\"A\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "español")
{
    textox.text = "Adivinar el futuro <sprite name=\"A\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "frances")
{
    textox.text = "Predire l’avenir <sprite name=\"A\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "aleman")
{
    textox.text = "Die Zukunft vorhersagen <sprite name=\"A\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "italiano")
{
    textox.text = "Predire il futuro <sprite name=\"A\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "portugues")
{
    textox.text = "Adivinhar o futuro <sprite name=\"A\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "japones")
{
    textox.text = "";
    textojx.text = "未来を予測する <sprite name=\"A\">";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "coreano")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "미래를 예측하다 <sprite name=\"A\">";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "chino")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "预测未来 <sprite name=\"A\">";
    textorx.text = "";
}
if(idioma == "ruso")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "предсказывать будущее <sprite name=\"A\">";
}
}

if(xbox == false && playst == false)
{
if(idioma == "ingles")
{
    textox.text = "Predict the future <sprite name=\"E\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "español")
{
    textox.text = "Adivinar el futuro <sprite name=\"E\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "frances")
{
    textox.text = "Predire l’avenir <sprite name=\"E\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "aleman")
{
    textox.text = "Die Zukunft vorhersagen <sprite name=\"E\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "italiano")
{
    textox.text = "Predire il futuro <sprite name=\"E\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "portugues")
{
    textox.text = "Adivinhar o futuro <sprite name=\"E\">";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "japones")
{
    textox.text = "";
    textojx.text = "未来を予測する <sprite name=\"E\">";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "coreano")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "미래를 예측하다 <sprite name=\"E\">";
    textocx.text = "";
    textorx.text = "";
}
if(idioma == "chino")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "预测未来 <sprite name=\"E\">";
    textorx.text = "";
}
if(idioma == "ruso")
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "предсказывать будущее <sprite name=\"E\">";
}
}
        }
        if(intering == true && freeze == true && !menu.activeInHierarchy)
        {
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
        }
 if(controller.height < 0.99 && crdd == false)
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
 if(controller.height >= 1 && crdd == true)
{
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
}
    }
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        intering = true;
    }
}
void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
        intering = false;
    }
}
}
