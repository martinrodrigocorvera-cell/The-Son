using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.PostProcessing;
using TMPro;

public class Buttons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool dmo;
    public GameObject redscreen;
    public GameObject copy;
    public GameObject light;
    public bool hell;
    public float hellock2;
    public GameObject camerax;
    public TMP_FontAsset normal;
    public TMP_FontAsset japo;
    public TMP_FontAsset cor;
    public TMP_FontAsset chi;
    public TMP_FontAsset ruso;
    public Slider slider;
    public AudioSource audio;
    public AudioClip btnsn;
    public AudioClip jsc2;
    public AudioSource audio2;
    public GameObject sl;
    public Button boton;
    public GameObject sets;
    public GameObject nor;
    public TMP_Text texto;
    public TMP_Text textoj;
    public TMP_Text textok;
    public TMP_Text textoc;
    public TMP_Text textor;
    public TMP_Text textoz;
    public TMP_Text textojz;
    public TMP_Text textokz;
    public TMP_Text textocz;
    public TMP_Text textorz;
    public Color colorNormal;
    public Color colorHover;
    public Color block;
    public bool res;
    public bool set;
    public bool ex;
    public bool scr;
    public bool snd;
    public bool vl;
    public bool lng;
    public bool lum;
    public bool cont;
    public bool back;
    public bool sybau;
    public TMP_Dropdown dropdown;
    public TMP_Dropdown dropdown2;
    public float lang;
    public Data dt;
    public string idiom;
    public string idioma;
    private bool isInitializing = true;
    public PostProcessVolume volume;
    private ColorAdjustments ajustesColor;
    private ColorGrading colorGrading;
    public Player play;
    public bool home;
    public bool newx;
    public float ng;
    public GameObject camm;
    public GameObject canvi;
    public GameObject canvii;
    public float games;
    public bool s2;
    public bool mkl;
    public GameObject men;
    public GameObject mennu;
    public bool exx;
    public GameObject playerx;
    public Vector3 spp = new Vector3(2.75968f, 11.696f, -2.213f);
    public GameObject cam;
    public GameObject cam2;
    public GameObject trans;
    public GameObject gamo;
    public int defaultt;
    public bool ex2;
    public bool ret;
    public int skip;
    public bool ngc;
    public bool ngc2;
    public bool contxx;
    public float pow;
    public bool cnx1;
    public bool cnx2;
    public bool cnx3;
    public bool cnx4;
    public bool cnx5;
    public bool cr1;
    public bool cr2;
    public bool cr3;
    public bool cr4;
    public bool cr5;
    public bool sns;
    public AudioClip pass;
    public Texture2D def;
    public Texture2D spe;
    public MovementCam camxy;
    public float sensi;
    public bool titlex;
    public bool homex;
    public bool ans1;
    public bool ans2;
    public bool ans3;
    public bool ans4;
    public GameObject answ;
    public GameObject wall;
 
    // Start is called before the first frame update
    void Start()
    {
    skip = PlayerPrefs.GetInt("Skp", 0);
        if(sybau == false)
        {
        boton.onClick.AddListener(TaskOnClick);
        }
    lang = PlayerPrefs.GetInt("Language", defaultt);
     if(vl == true)
     {
    games = PlayerPrefs.GetInt("Games", 0);
    float savedVolume = PlayerPrefs.GetFloat("Volume", 0.5f);
    slider.value = savedVolume;
    audio.volume = savedVolume;
    audio2.volume = savedVolume;
     }
     if(lum == true)
     {
            if (volume.profile.TryGetSettings(out colorGrading))
            {
                slider.minValue = -7f;
                slider.maxValue = -3f;

                float savedExposure = PlayerPrefs.GetFloat("Exposure", -5f);
                colorGrading.postExposure.value = savedExposure;
                slider.value = savedExposure;

                slider.onValueChanged.AddListener(CambiarExposicion);
            }
     }
        if (sns)
        {
            slider.minValue = 50f;
            slider.maxValue = 150f;
            float savedSens = PlayerPrefs.GetFloat("Sens", 100f);
            sensi = savedSens;
            camxy.mouseSensitivity = sensi;
            slider.value = sensi;
            slider.onValueChanged.AddListener(CambiarSens);
        }
    isInitializing = true;
    dropdown2.value = (int)lang;
    dropdown2.RefreshShownValue();
    UpdateTextosIdioma();
    isInitializing = false;

    dropdown2.onValueChanged.AddListener(OnUserChangedLanguage);
    }
    void OnEnable()
    {
    if(cont == true && games > 0)
    {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            textoz.color = colorNormal;
            textojz.color = colorNormal;
            textokz.color = colorNormal;
            textocz.color = colorNormal;
            textorz.color = colorNormal;
        boton.interactable = true;
   }
    }
    void Update()
    {

        if(set == true || res == true || back == true)
         {
            if(!gameObject.activeInHierarchy)
            {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            }
        }
if(ans4 == true)
{
if(play.textorder == 74)
{
if(idiom == "ingles")
{
    texto.text = "Do it your way";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Hazlo a tu manera";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Fais-le a ta maniere";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Mach es auf deine Weise";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Fallo a modo tuo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Faca do seu jeito";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "自分のやり方でやりなさい";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "네 방식대로 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "按你自己的方式去做";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Делай по-своему";
}
}
if(play.textorder == 73)
{
if(idiom == "ingles")
{
    texto.text = "It's good that you take inspiration from her, but you should move on";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Es bueno que tomes inspiracion de ella, pero deberias pasar pagina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "C'est bien que tu t'inspires d'elle, mais tu devrais tourner la page";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Es ist gut, dass du dich von ihr inspirieren lasst, aber du solltest weitermachen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "È bene che ti ispiri a lei, ma dovresti voltare pagina";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "E bom que voce se inspire nela, mas deveria seguir em frente";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女からインスピレーションを受けるのは良いことだけど、前に進むべきだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀에게서 영감을 받는 것은 좋지만, 이제는 잊어야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "从她身上获得灵感是好事，但你应该翻篇";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Хорошо, что ты черпаешь вдохновение у неё, но тебе стоит перевернуть страницу";
}
}
if(play.textorder == 72)
{
if(idiom == "ingles")
{
    texto.text = "You should be more dominant";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Deberias ser mas dominante";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu devrais etre plus dominant";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du solltest dominanter sein";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Dovresti essere piu dominante";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce deveria ser mais dominante";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "もっと支配的であるべきだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "더 지배적이어야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你应该更有主导性";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Тебе следует быть более доминирующим";
}
}
if(play.textorder == 71)
{
    if(idiom == "ingles")
    {
        texto.text = "She said the problem isn’t her mother, it’s actually you";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "español")
    {
        texto.text = "Dijo que el problema no es su madre, en realidad eres tu";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "frances")
    {
        texto.text = "Elle a dit que le probleme n'est pas sa mere, c'est en fait toi";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "aleman")
    {
        texto.text = "Sie sagte, das Problem ist nicht ihre Mutter, sondern eigentlich du";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "italiano")
    {
        texto.text = "Ha detto che il problema non e sua madre, sei in realta tu";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "portugues")
    {
        texto.text = "Ela disse que o problema nao e a mae dela, na verdade e voce";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "japones")
    {
        texto.text = "";
        textoj.text = "彼女は問題は母親じゃなくて、実はあなただと言った";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "coreano")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "그녀는 문제는 엄마가 아니라, 사실 너라고 했어";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "chino")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "她说问题不是她妈妈，实际上是你";
        textor.text = "";
    }
    if(idiom == "ruso")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "Она сказала, что проблема не в её матери, а в тебе";
    }
}
if(play.textorder == 70)
{
if(idiom == "ingles")
{
    texto.text = "No offense, but that girl is beyond help";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Sin ofender, pero esa chica no tiene remedio";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Sans vouloir offenser, mais cette fille est irrécupérable";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ohne beleidigen zu wollen, aber dieses Mädchen ist hoffnungslos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Senza offesa, ma quella ragazza è senza speranza";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Sem querer ofender, mas essa garota não tem salvação";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "悪気はないけど、あの子はもう手の施しようがない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "기분 상하게 할 생각은 없지만, 그 애는 답이 없어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "无意冒犯，但那个女孩已经没救了";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Без обид, но эту девушку уже не исправить";
}
}
if(play.textorder == 63)
{
if(idiom == "ingles")
{
    texto.text = "Can we not talk about that?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Podemos no hablar de eso?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Peut-on ne pas parler de ca ?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Konnen wir nicht daruber reden?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Possiamo non parlare di questo?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Podemos nao falar sobre isso?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "それについて話さないでいいですか？";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그거에 대해 말하지 않을 수 있을까?";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我们可以不谈那个吗？";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Можем не говорить об этом?";
}
}
if(play.textorder == 62)
{
if(idiom == "ingles")
{
    texto.text = "My father abandoned me when he discovered that I could see spirits";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Mi padre me abandono cuando descubrio que podia ver espiritus";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Mon pere m'a abandonne quand il a decouvert que je pouvais voir des esprits";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Mein Vater hat mich verlassen, als er entdeckte, dass ich Geister sehen konnte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Mio padre mi ha abbandonato quando ha scoperto che potevo vedere gli spiriti";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Meu pai me abandonou quando descobriu que eu podia ver espiritos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "父は、私が霊を見ることができると知った時、私を捨てた";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "아버지는 내가 영혼을 볼 수 있다는 걸 알게 되었을 때 나를 버렸어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我父亲在发现我能看见灵魂后抛弃了我";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Мой отец бросил меня, когда узнал, что я могу видеть духов";
}
}
if(play.textorder == 61)
{
if(idiom == "ingles")
{
    texto.text = "You are quite mature, you should be in charge";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Eres bastante madura, tu deberias estar al mando";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu es assez mature, tu devrais etre aux commandes";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du bist ziemlich reif, du solltest das Sagen haben";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Sei abbastanza matura, dovresti essere al comando";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce e bastante madura, deveria estar no comando";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "あなたはかなり大人だ、指揮を取るべきだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "너는 꽤 성숙해, 네가 주도해야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你相当成熟，你应该掌控局面";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ты достаточно взрослая, тебе следует быть во главе";
}
}
if(play.textorder == 60)
{
if(idiom == "ingles")
{
    texto.text = "Deep down, you care about him… right?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "En el fondo te preocupas por el… verdad?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Au fond, tu tiens a lui… n'est-ce pas ?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Tief im Inneren sorgst du dich um ihn… oder?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "In fondo, tieni a lui… vero?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "No fundo, voce se importa com ele… nao e?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "本当は彼のことを気にかけてるんでしょ…？";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "속으로는 그를 걱정하고 있지… 맞지?";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你内心其实关心他…对吧？";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "В глубине души тебе не всё равно на него… правда?";
}
}
if(play.textorder == 59)
{
if(idiom == "ingles")
{
    texto.text = "At least your family member isn't trying to kill you.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Tu familiar al menos no intenta matarte.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Au moins, un membre de ta famille n'essaie pas de te tuer.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Zumindest versucht ein Familienmitglied von dir nicht, dich zu toten.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Almeno un tuo familiare non cerca di ucciderti.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Pelo menos um membro da sua família não tenta te matar.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "少なくとも君の家族は君を殺そうとはしていない。";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "적어도 네 가족은 너를 죽이려 하진 않아.";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "至少你的家人没有想杀你。";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "По крайней мере, член твоей семьи не пытается тебя убить.";
}
}
}






if(ans3 == true)
{
if(play.textorder == 74)
{
if(idiom == "ingles")
{
    texto.text = "Do it her way";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Hazlo a su manera";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Fais-le a sa maniere";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Mach es auf ihre Weise";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Fallo a modo suo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Faca do jeito dela";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女のやり方でやりなさい";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀 방식대로 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "按她的方式去做";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Делай по‑её‑своему";
}
}
if(play.textorder == 73)
{
if(idiom == "ingles")
{
    texto.text = "Maybe you're the one living in the past, not your daughter";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Tal vez eres tu el que vive en el pasado y no tu hija";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Peut-etre que c'est toi qui vis dans le passe, et pas ta fille";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Vielleicht bist du es, der in der Vergangenheit lebt, und nicht deine Tochter";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Forse sei tu quello che vive nel passato e non tua figlia";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Talvez seja voce quem vive no passado e nao sua filha";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "もしかしたら過去に生きているのはあなただけで、娘ではない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "어쩌면 과거에 사는 건 너고, 네 딸이 아니야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "也许活在过去的是你，而不是你的女儿";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Возможно, живёшь в прошлом не ты, а твоя дочь";
}
}
if(play.textorder == 72)
{
if(idiom == "ingles")
{
    texto.text = "She should listen to you";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Ella deberia hacerte caso";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Elle devrait t'ecouter";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Sie sollte auf dich horen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Lei dovrebbe ascoltarti";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Ela deveria te ouvir";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女はあなたの言うことを聞くべきだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀는 네 말을 들어야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "她应该听你的";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ей следует слушать тебя";
}
}
if(play.textorder == 71)
{
    if(idiom == "ingles")
    {
        texto.text = "Nothing important";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "español")
    {
        texto.text = "Nada importante";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "frances")
    {
        texto.text = "Rien d'important";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "aleman")
    {
        texto.text = "Nichts Wichtiges";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "italiano")
    {
        texto.text = "Niente di importante";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "portugues")
    {
        texto.text = "Nada importante";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "japones")
    {
        texto.text = "";
        textoj.text = "大したことない";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "coreano")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "중요한 건 아니야";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "chino")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "没什么重要的";
        textor.text = "";
    }
    if(idiom == "ruso")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "Ничего важного";
    }
}
if(play.textorder == 70)
{
if(idiom == "ingles")
{
    texto.text = "The truth is, the problem isn't only hers";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "La verdad es que el problema no solo es suyo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "La verite, c'est que le probleme n'est pas seulement le sien";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Die Wahrheit ist, dass das Problem nicht nur ihres ist";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "La verita e che il problema non e solo suo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "A verdade e que o problema nao e so dela";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "実は、問題は彼女だけのものじゃない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "사실 문제는 그녀만의 문제가 아니야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "事实上，问题不只是她的";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "По правде говоря, проблема не только в ней";
}
}
if(play.textorder == 63)
{
if(idiom == "ingles")
{
    texto.text = "You haven't told me your name, now that I think about it";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "No me has dicho tu nombre, ahora que lo pienso";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu ne m'as pas dit ton nom, maintenant que j'y pense";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du hast mir deinen Namen nicht gesagt, jetzt wo ich darüber nachdenke";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Non mi hai detto il tuo nome, ora che ci penso";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce nao me disse seu nome, agora que penso nisso";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "今思えば、君の名前を教えてくれていなかったね";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "지금 생각해보니, 너 이름을 말해주지 않았네";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "现在想起来，你还没告诉我你的名字";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ты не сказал мне своё имя, если подумать";
}
}
if(play.textorder == 62)
{
if(idiom == "ingles")
{
    texto.text = "My parents...";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Mis padres...";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Mes parents...";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Meine Eltern...";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "I miei genitori...";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Meus pais...";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "私の両親...";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "나의 부모님...";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我的父母...";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Мои родители...";
}
}
if(play.textorder == 61)
{
if(idiom == "ingles")
{
    texto.text = "You think you've moved on, but it's not true, right?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Crees que has pasado pagina, pero no es asi, verdad?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu crois avoir tourne la page, mais ce n'est pas le cas, n'est-ce pas ?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du denkst, du hattest abgeschlossen, aber dem ist nicht so, oder?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Credi di aver voltato pagina, ma non e cosi, vero?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce acha que virou a pagina, mas nao e assim, nao e?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "前に進んだと思っているけど、そうじゃないんでしょ？";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "넘어갔다고 생각하지만, 사실 그렇지 않지?";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你以为自己已经翻篇了，但其实不是，对吧？";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ты думаешь, что перевернул страницу, но это не так, правда?";
}
}
if(play.textorder == 60)
{
if(idiom == "ingles")
{
    texto.text = "You try not to worry him anymore";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Intentas no preocuparle mas";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu essaies de ne plus t'inquiéter pour lui";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du versuchst, ihn nicht mehr zu beunruhigen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Cerchi di non preoccuparti piu per lui";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Você tenta nao se preocupar mais com ele";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼を心配させないようにしている";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그를 더 이상 걱정하게 하지 않으려 노력해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你试着不再让他担心";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ты пытаешься больше его не беспокоить";
}
}
if(play.textorder == 59)
{
if(idiom == "ingles")
{
    texto.text = "I thought this was about your mother, why did your father say that?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Crei que esto era sobre tu madre, por que tu padre dijo eso?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Je pensais que c'était a propos de ta mere, pourquoi ton pere a-t-il dit ca ?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ich dachte, es ging um deine Mutter, warum hat dein Vater das gesagt?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Pensavo che fosse una questione di tua madre, perché tuo padre ha detto questo?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Achei que isso fosse sobre sua mae, por que seu pai disse isso?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "これは君のお母さんのことだと思ってたけど、どうしてお父さんはそんなことを言ったの？";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "이게 네 엄마에 대한 얘기인 줄 알았는데, 왜 네 아버지는 그런 말을 했어?";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我以为这是关于你母亲的，为什么你父亲会那样说？";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Я думал, что это связано с твоей матерью, почему твой отец так сказал?";
}
}
}



if(ans2 == true)
{
if(play.textorder == 84)
{
if(idiom == "ingles")
{
    texto.text = "Ask about her mother so she sees how wrong her dad is";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Preguntar sobre su madre para que vea lo equivocado que está su padre";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Demander a propos de sa mere pour qu'elle voie a quel point son pere a tort";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Nach ihrer Mutter fragen, damit sie sieht, wie falsch ihr Vater liegt";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Chiedere di sua madre affinche veda quanto ha torto suo padre";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Perguntar sobre a mae dela para que ela veja o quanto o pai este errado";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女の母親について聞いて、父親がどれだけ間違っているかを見せる";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀에게 엄마에 대해 물어 아버지가 얼마나 잘못했는지 보여준다";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "询问她的母亲，让她看到她爸爸有多错";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Спросить о её матери, чтобы она увидела, насколько неправ её отец";
}
}
if(play.textorder == 79)
{
if(idiom == "ingles")
{
    texto.text = "Ask about his daughter so that he remembers what truly matters";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Preguntar sobre su hija para que recuerde lo que importa de verdad";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Lui demander a propos de sa fille pour qu'il se souvienne de ce qui compte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Nach seiner Tochter fragen, damit er sich an das Wichtigste erinnert";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Chiedere di sua figlia affinche ricordi cio che conta davvero";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Perguntar sobre a filha dele para que ele se lembre do que realmente importa";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼の娘について聞いて、本当に大切なことを思い出させる";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그의 딸에 대해 물어 정말로 중요한 것이 무엇인지 떠올리게 한다";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "询问他的女儿，让他记起真正重要的东西";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Спросить о его дочери, чтобы он вспомнил, что действительно важно";
}
}
if(play.textorder == 74)
{
if(idiom == "ingles")
{
    texto.text = "Find a solution you both agree on";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Busca una solucion en la que ambos esteis de acuerdo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Cherchez une solution sur laquelle vous etes tous les deux d'accord";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Finde eine Losung, der ihr beide zustimmt";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Cerca una soluzione su cui entrambi siete d'accordo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Procure uma solucao com a qual ambos concordem";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "二人とも同意できる解決策を探して";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "둘 다 동의할 수 있는 해결책을 찾아";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "寻找一个你们双方都同意的解决方案";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Найдите решение, с которым вы оба согласны";
}
}
if(play.textorder == 73)
{
if(idiom == "ingles")
{
    texto.text = "You should let your wife go. She will only make you suffer";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Deberias dejar ir a tu mujer. Solo te hara sufrir";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu devrais laisser partir ta femme. Elle ne fera que te faire souffrir";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du solltest deine Frau gehen lassen. Sie wird dir nur Leid zufügen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Dovresti lasciar andare tua moglie. Ti fara solo soffrire";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce deveria deixar sua esposa ir. Ela so vai te fazer sofrer";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "奥さんを手放すべきだ。彼女は君を苦しめるだけだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "아내를 놓아줘야 해. 그녀는 너를 힘들게 할 뿐이야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你应该放手你的妻子，她只会让你受苦";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Тебе следует отпустить свою жену. Она принесёт тебе лишь страдания";
}
}
if(play.textorder == 72)
{
if(idiom == "ingles")
{
    texto.text = "You both need to understand each other";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Ambos teneis que entenderos";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Vous devez tous les deux vous comprendre";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ihr beide musst euch verstehen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Entrambi dovete capirvi";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Ambos tem que se entender";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "お互いに理解し合う必要がある";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "둘 다 서로를 이해해야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你们双方都需要互相理解";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Вам обоим нужно понимать друг друга";
}
}
if(play.textorder == 71)
{
    if(idiom == "ingles")
    {
        texto.text = "She doesn't feel heard";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "español")
    {
        texto.text = "No se siente escuchada";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "frances")
    {
        texto.text = "Elle ne se sent pas ecoutee";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "aleman")
    {
        texto.text = "Sie fuhlt sich nicht gehort";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "italiano")
    {
        texto.text = "Non si sente ascoltata";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "portugues")
    {
        texto.text = "Ela nao se sente ouvida";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "japones")
    {
        texto.text = "";
        textoj.text = "彼女は聞いてもらえていないと感じている";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "coreano")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "그녀는 자신의 말을 들어주지 않는다고 느껴";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "chino")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "她觉得没有被倾听";
        textor.text = "";
    }
    if(idiom == "ruso")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "Она чувствует, что её не слушают";
    }
}
if(play.textorder == 70)
{
if(idiom == "ingles")
{
    texto.text = "You should raise her better";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Deberias educarla mejor";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu devrais mieux l'eduquer";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du solltest sie besser erziehen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Dovresti educarla meglio";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce deveria educa-la melhor";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "もっとちゃんとしつけるべきだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀를 더 잘 가르쳐야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你应该把她教得更好一点";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Тебе следует лучше её воспитывать";
}
}
if(play.textorder == 63)
{
if(idiom == "ingles")
{
    texto.text = "Don't worry, it's okay";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "No te preocupes, esta bien";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Ne t'inquiete pas, ca va";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Keine Sorge, es ist okay";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Non preoccuparti, va bene";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Não se preocupe, esta tudo bem";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "心配しないで、大丈夫だよ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "걱정하지 마, 괜찮아";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "别担心，没关系";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Не переживай, всё в порядке";
}
}
if(play.textorder == 62)
{
if(idiom == "ingles")
{
    texto.text = "I have no parents";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "No tengo padres";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Je n'ai pas de parents";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ich habe keine Eltern";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Non ho genitori";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Não tenho pais";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "私は親がいない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "나는 부모가 없어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我没有父母";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "У меня нет родителей";
}
}
if(play.textorder == 61)
{
if(idiom == "ingles")
{
    texto.text = "You miss her, right? Your mother.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "La echas de menos, verdad? Tu madre.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Elle te manque, n'est-ce pas ? Ta mere.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du vermisst sie, oder? Deine Mutter.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Ti manca, vero? Tua madre.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce sente falta dela, nao é? Sua mae.";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女が恋しいんでしょ？君のお母さん。";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀가 그립지? 네 엄마.";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你想念她，对吧？你妈妈。";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ты по ней скучаешь, правда? По своей матери.";
}
}
if(play.textorder == 60)
{
if(idiom == "ingles")
{
    texto.text = "You're only hurting yourself";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Solo te torturas a ti misma";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu ne fais que te faire du mal";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du schadest dir nur selbst";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Ti stai solo facendo del male";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce so está se machucando";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "あなたは自分自身を傷つけているだけです";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "너 자신만 다치고 있어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你只是伤害你自己";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ты лишь причиняешь боль себе";
}
}
if(play.textorder == 59)
{
if(idiom == "ingles")
{
    texto.text = "He should listen to you";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "El deberia escucharte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Il devrait t'ecouter";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Er sollte dir zuhoren";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Dovrebbe ascoltarti";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Ele deveria te ouvir";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼は君の話を聞くべきだ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그는 네 말을 들어야 해";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "他应该听你说";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Ему следует тебя слушать";
}
}
}




if(ans1 == true)
{
if(play.textorder == 84)
{
if(idiom == "ingles")
{
    texto.text = "Ask about her father so she realizes what he does for her";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Preguntar sobre su padre para que se de cuenta de lo que hace por ella";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Demander a propos de son pere pour qu'elle realise ce qu'il fait pour elle";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Nach ihrem Vater fragen, damit sie erkennt, was er fur sie tut";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Chiedere di suo padre affinche si renda conto di cio che fa per lei";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Perguntar sobre o pai dela para que ela perceba o que ele faz por ela";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女の父親について聞いて、彼が彼女のためにしていることに気づかせる";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀에게 아버지에 대해 물어, 그가 그녀를 위해 무엇을 하는지 깨닫게 한다";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "询问她的父亲，让她意识到他为她所做的一切";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Спросить о её отце, чтобы она поняла, что он делает для неё";
}
}
if(play.textorder == 79)
{
if(idiom == "ingles")
{
    texto.text = "Ask about his wife so that he remembers to act like her";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Preguntar sobre su esposa para que recuerde actuar como ella";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Lui demander a propos de sa femme pour qu'il se souvienne d'agir comme elle";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Nach seiner Frau fragen, damit er sich daran erinnert, wie sie zu handeln";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Chiedere di sua moglie affinche ricordi di comportarsi come lei";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Perguntar sobre a esposa dele para que ele se lembre de agir como ela";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼の妻について聞いて、彼女のように振る舞うことを思い出させる";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그의 아내에 대해 물어 그녀처럼 행동하는 것을 떠올리게 한다";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "询问他的妻子，让他记起要像她一样行事";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Спросить о его жене, чтобы он вспомнил, как вести себя как она";
}
}
if(play.textorder == 74)
{
if(idiom == "ingles")
{
    texto.text = "I'm sure you will find the right answer";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Estoy seguro de que encontraras la respuesta correcta";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Je suis sur que tu trouveras la bonne reponse";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ich bin sicher, dass du die richtige Antwort finden wirst";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Sono sicuro che troverai la risposta giusta";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Tenho certeza de que voce encontrar a resposta certa";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "きっと正しい答えを見つけられるでしょう";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "틀림없이 네가 올바른 답을 찾을 거야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我相信你会找到正确的答案";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Я уверен, что ты найдёшь правильный ответ";
}
}
if(play.textorder == 73)
{
if(idiom == "ingles")
{
    texto.text = "Your wife this, your wife that, can't you do anything on your own?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Tu mujer esto, tu mujer lo otro, acaso no puedes hacer nada solo?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Ta femme ci, ta femme ca, ne peux-tu rien faire tout seul ?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Deine Frau dies, deine Frau das, kannst du nichts alleine machen?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Tua moglie questo, tua moglie quello, non puoi fare nulla da solo?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Tua esposa isto, tua esposa aquilo, nao consegues fazer nada sozinho?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "奥さんがこれ、奥さんがあれ、一人で何もできないのか？";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "네 아내 이것, 네 아내 저것, 혼자 아무것도 못하겠니?";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "你老婆这个，你老婆那个，你自己就不能做点什么吗？";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Твоя жена это, твоя жена то, разве ты ничего не можешь сделать сам?";
}
}
if(play.textorder == 72)
{
if(idiom == "ingles")
{
    texto.text = "What she said actually makes sense";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Lo que ella dijo en realidad tiene sentido";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Ce qu'elle a dit a en fait du sens";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Was sie gesagt hat, ergibt eigentlich Sinn";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Quello che ha detto in realta ha senso";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "O que ela disse realmente faz sentido";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼女の言ったことは実は筋が通っている";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그녀가 한 말이 사실 일리가 있어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "她说的其实很有道理";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "То, что она сказала, на самом деле имеет смысл";
}
}
if(play.textorder == 71)
{
    if(idiom == "ingles")
    {
        texto.text = "Just teenage dramas";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "español")
    {
        texto.text = "Solo dramas adolescentes";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "frances")
    {
        texto.text = "Juste des drames d'adolescents";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "aleman")
    {
        texto.text = "Nur Teenager-Dramen";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "italiano")
    {
        texto.text = "Solo drammi adolescenziali";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "portugues")
    {
        texto.text = "Apenas dramas adolescentes";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "japones")
    {
        texto.text = "";
        textoj.text = "ただのティーンドラマ";
        textok.text = "";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "coreano")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "그냥 청소년 드라마일 뿐이야";
        textoc.text = "";
        textor.text = "";
    }
    if(idiom == "chino")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "只是青春剧";
        textor.text = "";
    }
    if(idiom == "ruso")
    {
        texto.text = "";
        textoj.text = "";
        textok.text = "";
        textoc.text = "";
        textor.text = "Просто подростковые драмы";
    }
}
if(play.textorder == 70)
{
if(idiom == "ingles")
{
    texto.text = "It went well";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Ha ido bien";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Ca s'est bien passé";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Es ist gut gelaufen";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "E andata bene";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Correu bem";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "うまくいった";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "잘 됐어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "进展得很顺利";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Всё прошло хорошо";
}
}
if(play.textorder == 63)
{
if(idiom == "ingles")
{
    texto.text = "By the way, what's your name?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "A todo esto, cual es tu nombre?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Au fait, comment tu t'appelles ?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ubrigens, wie heißt du?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "A proposito, come ti chiami?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "A proposito, qual e o seu nome?";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "ところで、君の名前は？";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그런데, 네 이름이 뭐야?";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "对了，你叫什么名字？";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Кстати, как тебя зовут?";
}
}
if(play.textorder == 62)
{
if(idiom == "ingles")
{
    texto.text = "My mother died";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Mi madre murio";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Ma mere est morte";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Meine Mutter ist gestorben";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Mia madre e morta";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Minha mae morreu";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "母が亡くなった";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "어머니가 돌아가셨어";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "我母亲去世了";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Моя мать умерла";
}
}

if(play.textorder == 61)
{
if(idiom == "ingles")
{
    texto.text = "Even if he is wrong, you have a lot in common";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Aun si esta equivocado, teneis mucho en comun";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Même s'il a tort, vous avez beaucoup en commun";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Auch wenn er falsch liegt, habt ihr viel gemeinsam";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Anche se ha torto, avete molto in comune";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Mesmo que ele esteja errado, voces tem muito em comum";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "たとえ彼が間違っていても、あなたたちは共通点が多い";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그가 틀렸더라도, 너희는 공통점이 많아";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "即使他错了，你们也有很多共同点";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Даже если он неправ, у вас много общего";
}
}
if(play.textorder == 60)
{
if(idiom == "ingles")
{
    texto.text = "Maybe if you talk to him about this, he'll come to his senses";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Tal vez si hablas con el de esto entre en razon";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Peut-etre que si tu lui parles de ca, il reviendra a la raison";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Vielleicht, wenn du mit ihm daruber sprichst, kommt er zur Vernunft";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Forse se parli con lui di questo, tornerà in sé";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Talvez se voce falar com ele sobre isso, ele volte a raciocinar";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "もしかしたら、これについて彼と話せば、分別がつくかもしれない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "아마 이것에 대해 그와 이야기하면 제정신을 차릴 거야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "也许如果你跟他谈谈这件事，他就会清醒过来";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Возможно, если ты поговоришь с ним об этом, он придёт в себя";
}
}
if(play.textorder == 59)
{
if(idiom == "ingles")
{
    texto.text = "He only cares about you";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "El solo se preocupa por ti";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Il ne se soucie que de toi";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Er kummert sich nur um dich";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Si preoccupa solo di te";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Ele so se preocupa com voce";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "彼は君のことしか気にしていない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "그는 너만 신경 써";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "他只关心你";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Он заботится только о тебе";
}
}
}
            hellock2 = PlayerPrefs.GetFloat("Plus2");
    if(sns == true)
    {
    camxy.mouseSensitivity = sensi;
    sensi = camxy.mouseSensitivity;
    }
    if(skip == 1)
    {
    home = play.home;
    if(home == true && !gamo.activeInHierarchy && cont == true)
    {
        Invoke("t15", 0.5f);
    }
    }
    defaultt = dt.defaultt;
    if(cont == true)
    {
    ng = dt.night;
    }
    games = dt.games;
    if(titlex == false)
    {
    if(cont == true && games > 0 && mkl == false)
    {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            textoz.color = colorNormal;
            textojz.color = colorNormal;
            textokz.color = colorNormal;
            textocz.color = colorNormal;
            textorz.color = colorNormal;
        boton.interactable = true;
        mkl = true;
   }
    if(cont == true && games == 0)
    {
            texto.color = block;
            textoj.color = block;
            textok.color = block;
            textoc.color = block;
            textor.color = block;
            textoz.color = block;
            textojz.color = block;
            textokz.color = block;
            textocz.color = block;
            textorz.color = block;
        boton.interactable = false;
    }
    }
        idiom = dt.idioma;
     if(sl.activeInHierarchy && vl == true)
     {
     audio.volume = slider.value;
     audio2.volume = slider.value;
     PlayerPrefs.SetFloat("Volume", slider.value);
     PlayerPrefs.Save();
     }
       if(sns == true)
       {
if(idiom == "ingles")
{
    texto.text = "Sensitivity";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Sensibilidad";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Sensibilite";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Empfindlichkeit";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Sensibilita";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Sensibilidade";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "感度";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "민감도";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "灵敏度";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "сенс";
}
       }
       if(dmo == true)
       {
if(idiom == "ingles")
{
    texto.text = "End of the demo!";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Fin de la demo!";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Fin de la demo !";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Ende der Demo!";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Fine della demo!";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Fim da demo!";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "デモ終了！";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "데모 종료!";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "试玩版结束！";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Конец демо!";
}
       }
       if(cr5 == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Designer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Disenador";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Designer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Designer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Designer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "desenhista";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "デザイナー";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "디자이너";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "程序员";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "дизайнер";
         }
       }
       if(cr4 == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Artist";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Artista";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Artiste";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Kunstler";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Artista";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Artista";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "アーティスト";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "아티스트";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "程序员";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "программист";
         }
       }
       if(cr3 == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Programmer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Programador";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "programmeur";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Programmierer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "programmatore";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "programador";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "プログラマー";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "프로그램 제작자";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "程序员";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "программист";
         }
       }
       if(cr2 == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Story";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Historia";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Histoire";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Geschichte";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Storia";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Historia";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "歴史";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "역사";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "历史";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "история";
         }
       }
       if(cr1 == true && cr4 == true)
       {
if(idiom == "ingles")
{
    texto.text = "Return";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Volver";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Retour";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Zuruck";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Ritorno";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voltar";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "戻る";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "돌아가기";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "返回";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Назад";
}
       }
       if(cr1 == true && cr5 == true)
       {
if(idiom == "ingles")
{
    texto.text = "Next";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Siguiente";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Suivant";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Weiter";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Avanti";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Proximo";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "次へ";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "다음";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "下一个";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Далее";
}
       }
       if(cr1 == true)
       {
if(idiom == "ingles")
{
    texto.text = "Music";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Musica";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Musique";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Musik";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Musica";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Musica";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "音楽";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "음악";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "音乐";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Музыка";
}
       }
       if(cnx5 == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Thanks for playing!";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Gracias por jugar!";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Merci d avoir joue!";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Danke furs Spielen!";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Grazie per aver giocato!";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Obrigado por jogar!";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "遊んでくれてありがとう！";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "플레이해주셔서 감사합니다!";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "感谢您的参与！";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "Спасибо за игру!";
         }
       }
       if(cnx4 == true)
       {
         if(!wall.activeInHierarchy)
         {
         if(idiom == "ingles")
         {
         texto.text = "For now...";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Por ahora...";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Pour l instant...";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Zur Zeit...";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Per ora...";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Por agora...";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "今のところ...";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "지금으로서는...";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "目前...";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "На данный момент...";
         }
         }
         if(wall.activeInHierarchy)
         {
if(idiom == "ingles")
{
    texto.text = "You are never alone in the darkness";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Nunca estas solo en la oscuridad";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu n'es jamais seul dans l'obscurite";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du bist in der Dunkelheit niemals allein";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Non sei mai solo nell'oscurita";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce nunca esta sozinho na escuridao";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "闇の中でも、あなたは決して一人じゃない";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "어둠 속에서도 너는 결코 혼자가 아니야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "在黑暗中，你从不孤单";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "В темноте ты никогда не бываешь один";
}
         }
       }
       if(cnx3 == true)
       {
         if(!wall.activeInHierarchy)
         {
         if(idiom == "ingles")
         {
         texto.text = "All I know is that Im safe";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Todo lo que se es que estoy a salvo";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Tout ce que je sais, cest que je suis en securite";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Ich weiß nur dass ich in Sicherheit bin";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Tutto quello che so e che sono al sicuro";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Tudo o que sei e que estou seguro";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "私が知っているのは自分が安全だということだけです";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "내가 아는 건 내가 안전하다는 것뿐이에요";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "我只知道我很安全";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "Я знаю только что я в безопасности";
         }
         }
         if(wall.activeInHierarchy)
         {
if(idiom == "ingles")
{
    texto.text = "You will always have someone to guide you in the end, someone to show you the light";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Siempre tendras a alguien para guiarte al final, alguien para mostrarte la luz";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Tu auras toujours quelqu'un pour te guider jusqu'a la fin, quelqu'un pour te montrer la lumiere";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Du wirst am Ende immer jemanden haben, der dich fuhrt, jemanden, der dir das Licht zeigt";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Avrai sempre qualcuno che ti guidera fino alla fine, qualcuno che ti mostrera la luce";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Voce sempre tera alguem para guia-lo ate o fim, alguem para lhe mostrar a luz";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "最後には、必ず導いてくれる誰かがいる。光を見せてくれる誰かが";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "끝에는 항상 너를 이끌어 줄 누군가가 있고, 빛을 보여 줄 누군가가 있을 거야";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "最终你总会有一个人指引你，带你看见光明";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "В конце концов у тебя всегда будет кто-то, кто поведёт тебя и покажет тебе свет";
}
         }
       }
       if(cnx2 == true)
       {
         if(!wall.activeInHierarchy)
         {
         if(idiom == "ingles")
         {
         texto.text = "She says that she probably ran out of time in the world of the living and was banished to hell";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "ella dice que probablemente se le acabo el tiempo en el mundo de los vivos y fue desterrada al infierno";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Elle dit quelle a probablement manque de temps dans le monde des vivants et quelle a ete bannie en enfer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Sie sagt dass ihr in der Welt der Lebenden wahrscheinlich die Zeit ausgegangen sei und sie in die Holle verbannt worden sei";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Afferma che probabilmente il suo tempo nel mondo dei vivi e scaduto ed e stata bandita all inferno";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Ela diz que provavelmente ficou sem tempo no mundo dos vivos e foi banida para o inferno";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "彼女はおそらく現世での時間が尽きて地獄に追放されたのだと言います";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "그녀는 아마도 이 세상에서 시간을 다 써버려 지옥으로 추방당했을 것이라고 말합니다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "她说她可能在人世间的时间已经不够了所以被放逐到了地狱";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "Она говорит что вероятно ее время в мире живых истекло и ее изгнали в ад";
         }
         }
         if(wall.activeInHierarchy)
         {
if(idiom == "ingles")
{
    texto.text = "Even if you believe you are alone, even if you cannot see the light at the end of the tunnel";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Aunque creas estar solo, aunque no vislumbres la luz al final del tunel";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Même si tu crois etre seul, meme si tu ne vois pas la lumiere au bout du tunnel";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Auch wenn du glaubst, allein zu sein, auch wenn du das Licht am Ende des Tunnels nicht siehst";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Anche se credi di essere solo, anche se non scorgi la luce in fondo al tunnel";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Mesmo que voce acredite estar sozinho, mesmo que nao veja a luz no fim do tunel";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "たとえ一人だと思っても、トンネルの先の光が見えなくても";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "혼자라고 느껴지고, 터널 끝의 빛이 보이지 않더라도";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "即使你觉得自己孤身一人，即使看不见隧道尽头的光";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Даже если тебе кажется, что ты один, даже если ты не видишь свет в конце туннеля";
}
         }
       }

       if(cnx1 == true)
       {
         if(!wall.activeInHierarchy)
         {
         if(idiom == "ingles")
         {
         texto.text = "Shortly after I spoke to Grandma about what happened at the end of that night";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Poco despues le hable a la abuela sobre lo que paso al final de aquella noche";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Peu de temps apres jai parle a grand-mere de ce qui sest passe a la fin de cette nuit-la";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Kurz darauf sprach ich mit Oma uber das was am Ende dieser Nacht passiert war";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Poco dopo ho parlato con la nonna di quello che era successo alla fine di quella notte";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Pouco depois de falar com a vovo sobre o que aconteceu no final daquela noite";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "その夜の終わりに何が起こったのかおばあちゃんに話した直後";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "나는 할머니께 그날 밤 무슨 일이 있었는지 말씀드린 직후";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "不久之后我和奶奶谈起了那天晚上发生的事情";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "Вскоре после того как я поговорил с бабушкой о том что произошло в конце той ночи";
         }
         }

         if(wall.activeInHierarchy)
         {
if(idiom == "ingles")
{
    texto.text = "Even if you think there is no hope, even if you sink into the abyss of loneliness";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "español")
{
    texto.text = "Aunque creas que no hay esperanzas, aunque te hundas en el abismo de la soledad";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "frances")
{
    texto.text = "Meme si tu crois qu'il n'y a aucun espoir, meme si tu sombr es dans l'abime de la solitude";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "aleman")
{
    texto.text = "Auch wenn du glaubst, dass es keine Hoffnung gibt, selbst wenn du im Abgrund der Einsamkeit versinkst";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "italiano")
{
    texto.text = "Anche se credi che non ci sia speranza, anche se sprofondi nell'abisso della solitudine";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "portugues")
{
    texto.text = "Mesmo que voce ache que nao ha esperança, mesmo que afunde no abismo da solidao";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "japones")
{
    texto.text = "";
    textoj.text = "希望がないと思っても、孤独の深淵に沈んでも";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "희망이 없다고 느껴지고, 외로움의 심연에 빠진다 해도";
    textoc.text = "";
    textor.text = "";
}
if(idiom == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "即使你觉得毫无希望，即使你坠入孤独的深渊";
    textor.text = "";
}
if(idiom == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "Даже если ты думаешь, что надежды нет, даже если ты погружаешься в бездну одиночества";
}
         }
        }
       if(ngc2 == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "ESCAPE FROM HOME";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Escapa de Casa";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "s'echapper de chez soi";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Flucht aus der Heimat";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "fuga da casa";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "fugir de casa";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "家から逃げる";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "집에서 탈출하다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "离家出走";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "побег из дома";
         }
        }
       if(ngc == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Night Completed";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Noche Completada";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Nuit terminee";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Nacht abgeschlossen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Notte completata";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Noite Concluida";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "完了した夜";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "완료된 밤";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "完成之夜";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "Завершенная ночь";
         }
        }
       if(contxx == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Continue";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Continuar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Continuer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "weitermachen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Continuare";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Continuar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "続く";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "계속하다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "继续";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "продолжать";
         }
        }
         if(ret == true && contxx == false)
         {

         if(idiom == "ingles")
         {
         texto.text = "Retry";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Reintentar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Reessayer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "wiederholen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "riprovare";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Repetir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "リトライ";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "다시 해 보다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "重试";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "повторить";
         }
         }
         if(ex2 == true)
         {

         if(idiom == "ingles")
         {
         texto.text = "Exit";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Salir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Sortir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Hinausgehen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Esci";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Sair";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "外出";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "나가다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "出去";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "выходить";
         }
         }
// HOME STUFF
         if(exx == true)
         {
         if(idiom == "ingles")
         {
         texto.text = "Exit";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Salir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Sortir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Hinausgehen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Esci";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Sair";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "外出";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "나가다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "出去";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "выходить";
         }
         }
         if(set == true)
         {
         if(idiom == "ingles")
         {
         texto.text = "Settings";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Ajustes";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Parametres";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Einstellungen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Impostazioni";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Configuracoes";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "設定";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "설정";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "设置";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "настройки";
         }
         }
       if(cont == true && titlex == false)
       {
         if(idiom == "ingles")
         {
         texto.text = "Continue";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "Night " + ng;
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Continuar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "Noche " + ng;
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Continuer";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "Nuit " + ng;
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "weitermachen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "Nacht " + ng;
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Continuare";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "Notte " + ng;
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Continuar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "Noite " + ng;
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "続く";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         textoz.text = "";
         textojz.text = "夜 " + ng;
         textokz.text = "";
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "계속하다";
         textoc.text = "";
         textor.text = "";
         textoz.text = "";
         textojz.text = "";
         textokz.text = "밤 " + ng;
         textocz.text = "";
         textorz.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "继续";
         textor.text = "";
         textoz.text = "";
         textojz.text = "";
         textokz.text = "";
         textocz.text = "晚上 " + ng;
         textorz.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "продолжать";
         textoz.text = "";
         textojz.text = "";
         textokz.text = "";
         textocz.text = "";
         textorz.text = "ночь " + ng;
         }
        }
       if(newx == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "New Game";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Nueva Partida";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Nouveau jeu";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Neues Spiel";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Nuovo gioco";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Novo jogo";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "新しいゲーム";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "새로운 게임";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "新游戏";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "Новая игра";
         }
        }

     if(sets.activeInHierarchy)
     {
       if(lum == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Brightness";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Brillo";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Briller";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Gluhen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Incandescenza";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Brilho";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "輝き";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "광";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "辉光";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "светиться";
         }
        }
       if(lng == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Language";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Idioma";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Langue";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Sprache";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Lingua";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Linguagem";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "言語";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "언어";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "语言";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "язык";
         }
        }
       if(vl == true)
       {
         if(idiom == "ingles")
         {
         texto.text = "Volume";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Volumen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Volume";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Volumen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Volume";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Volume";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "音量";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "용량";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "体积";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "объем";
         }
       }

       if(scr == true)
       {
         if(idiom == "ingles")
         {
            dropdown.captionText.font = normal;
            dropdown.itemText.font = normal;
         dropdown.options[0].text = "Fullscreen";
         dropdown.options[1].text = "Windowed";
         texto.text = "Screen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
            dropdown.captionText.font = normal;
            dropdown.itemText.font = normal;
         dropdown.options[0].text = "Pantalla Completa";
         dropdown.options[1].text = "Ventana";
         texto.text = "Pantalla";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
            dropdown.captionText.font = normal;
            dropdown.itemText.font = normal;
         dropdown.options[0].text = "Plein Ecran";
         dropdown.options[1].text = "Fenetre";
         texto.text = "Ecran";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
            dropdown.captionText.font = normal;
            dropdown.itemText.font = normal;
         dropdown.options[0].text = "Vollbild";
         dropdown.options[1].text = "Fenster";
         texto.text = "Bildschirm";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
            dropdown.captionText.font = normal;
            dropdown.itemText.font = normal;
         dropdown.options[0].text = "Schermo Intero";
         dropdown.options[1].text = "Finestra";
         texto.text = "Schermo";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
            dropdown.captionText.font = normal;
            dropdown.itemText.font = normal;
         dropdown.options[0].text = "Tela Cheia";
         dropdown.options[1].text = "Janela";
         texto.text = "Tela";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
            dropdown.captionText.font = japo;
            dropdown.itemText.font = japo;
         dropdown.options[0].text = "全画面表示";
         dropdown.options[1].text = "ウィンドウ";
         texto.text = "";
         textoj.text = "画面";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
            dropdown.captionText.font = cor;
            dropdown.itemText.font = cor;
         dropdown.options[0].text = "전체 화면";
         dropdown.options[1].text = "창문";
         texto.text = "";
         textoj.text = "";
         textok.text = "화면";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
            dropdown.captionText.font = chi;
            dropdown.itemText.font = chi;
         dropdown.options[0].text = "全屏";
         dropdown.options[1].text = "窗户";
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "屏幕";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
            dropdown.captionText.font = ruso;
            dropdown.itemText.font = ruso;
         dropdown.options[0].text = "полноэкранный";
         dropdown.options[1].text = "окно";
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "экран";
         }
        dropdown.RefreshShownValue();
       }
     }
     if(sets.activeInHierarchy)
     {
         if(back == true)
         {
         if(idiom == "ingles")
         {
         texto.text = "Back";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Atras";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Dos";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Zuruck";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Indietro";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Voltar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "戻る";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "뒤쪽에";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "后退";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "назад";
         }
         }
     }
     if(nor.activeInHierarchy)
     {

         if(ex == true)
         {

         if(idiom == "ingles")
         {
         texto.text = "Exit";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Salir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Sortir";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Hinausgehen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Esci";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Sair";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "外出";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "나가다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "出去";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "выходить";
         }
         }

         if(set == true)
         {
         if(idiom == "ingles")
         {
         texto.text = "Settings";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Ajustes";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Parametres";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Einstellungen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Impostazioni";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Configuracoes";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "設定";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "설정";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "设置";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "настройки";
         }
         }
         if(res == true)
         {
         if(idiom == "ingles")
         {
         texto.text = "Resume";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "español")
         {
         texto.text = "Reanudar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "frances")
         {
         texto.text = "Reprendre";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "aleman")
         {
         texto.text = "Wieder Aufnehmen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "italiano")
         {
         texto.text = "Riprendere";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "portugues")
         {
         texto.text = "Retomar";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "japones")
         {
         texto.text = "";
         textoj.text = "再開する";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "재개하다";
         textoc.text = "";
         textor.text = "";
         }
         if(idiom == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "恢复";
         textor.text = "";
         }
         if(idiom == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "резюме";
         }
         }
     }
     if(hell == true)
     {
     homex = play.home;
     if(hellock2 == 0 && homex == true)
     {
            copy.SetActive(false);
            redscreen.SetActive(false);
            light.SetActive(true);
     }
     if(hellock2 == 1 && homex == true)
     {
            copy.SetActive(true);
            redscreen.SetActive(true);
            light.SetActive(false);
     }
     }
    }
    void SetCursor(Texture2D cursorTexture)
    {
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }

    void TaskOnClick()
    {
        if (sybau == false)
        {
        if(hell == false)
        {
        SetCursor(def);
        }

        if (hell == true)
        {
          if(hellock2 == 0)
          {
            hellock2 = 1f;
            PlayerPrefs.SetFloat("Plus2", hellock2);
            PlayerPrefs.Save();
          }
          else
          {
            hellock2 = 0f;
            PlayerPrefs.SetFloat("Plus2", hellock2);
            PlayerPrefs.Save();
          }
        }
if(titlex == false)
{
audio.PlayOneShot(btnsn);
}
if(ans1 == true)
{
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
play.answer = false;
play.option = "A";
play.speed2 = 0.03f;
play.textorder += 1;
         play.textod.text = "";
         play.textojd.text = "";
         play.textokd.text = "";
         play.textocd.text = "";
         play.textord.text = "";
answ.SetActive(false);
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
}
if(ans2 == true)
{
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
play.answer = false;
play.option = "B";
play.speed2 = 0.03f;
play.textorder += 1;
         play.textod.text = "";
         play.textojd.text = "";
         play.textokd.text = "";
         play.textocd.text = "";
         play.textord.text = "";
answ.SetActive(false);
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
}
if(ans3 == true)
{
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
play.answer = false;
play.option = "C";
play.speed2 = 0.03f;
play.textorder += 1;
         play.textod.text = "";
         play.textojd.text = "";
         play.textokd.text = "";
         play.textocd.text = "";
         play.textord.text = "";
answ.SetActive(false);
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
}
if(ans4 == true)
{
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
play.answer = false;
play.option = "D";
play.speed2 = 0.03f;
play.textorder += 1;
         play.textod.text = "";
         play.textojd.text = "";
         play.textokd.text = "";
         play.textocd.text = "";
         play.textord.text = "";
answ.SetActive(false);
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
}
    if(titlex == true)
    {
        Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
audio.PlayOneShot(jsc2);
    }
    if(ex == true)
    {
     trans.SetActive(true);
     Invoke("c3", 1f);
    }
    if(newx == true)
    {
PlayerPrefs.SetInt("taco", 0);
PlayerPrefs.SetInt("burr", 0);
PlayerPrefs.SetInt("nach", 0);
PlayerPrefs.SetInt("ques", 0);
PlayerPrefs.SetInt("frij", 0);
PlayerPrefs.SetInt("ench", 0);
PlayerPrefs.SetInt("tam", 0);
PlayerPrefs.SetInt("gua", 0);
PlayerPrefs.SetInt("mir", 0);
PlayerPrefs.SetInt("sel", 0);
PlayerPrefs.Save();
        Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
     trans.SetActive(true);
     Invoke("t1", 1f);
    }
    if(ret == true)
    {
        skip = 1;
        PlayerPrefs.SetInt("Skp", skip);
        PlayerPrefs.Save();
     trans.SetActive(true);
     Invoke("t5", 1f);
    }


    if(cont == true)
    {
        Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
     trans.SetActive(true);
     Invoke("t11", 1f);
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
    }


         if(res == true)
         {
            snd = true;
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
                texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
         }
         if(set == true)
         {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            sets.SetActive(true);
            if(s2 == false)
            {
            nor.SetActive(false);
            }
            if(s2 == true)
            {
            men.SetActive(true);
            nor.SetActive(false);
            canvi.SetActive(false);
            
            }
         }
         if(back == true)
         {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            if(!mennu.activeInHierarchy)
            {
            nor.SetActive(true);
            }
            sets.SetActive(false);
            if(mennu.activeInHierarchy)
            {
            men.SetActive(false);
            nor.SetActive(true);
            canvi.SetActive(true);
            }
         }
         if(exx == true)
         {
         Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
         }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (sybau == false)
        {
        if (boton.interactable)
        {
        if(titlex == false)
        {
        audio.PlayOneShot(pass);
        }
        SetCursor(spe);
        }
            texto.color = colorHover;
            textoj.color = colorHover;
            textok.color = colorHover;
            textoc.color = colorHover;
            textor.color = colorHover;
            if(cont == true && titlex == false)
            {
            textoz.color = colorHover;
            textojz.color = colorHover;
            textokz.color = colorHover;
            textocz.color = colorHover;
            textorz.color = colorHover;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (sybau == false)
        {
            SetCursor(def);
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            if(cont == true && titlex == false)
            {
            textoz.color = colorNormal;
            textojz.color = colorNormal;
            textokz.color = colorNormal;
            textocz.color = colorNormal;
            textorz.color = colorNormal;
            }
        }
    }

    void ChangeScreenMode(int option)
    {
        ApplyScreenMode(option);
        PlayerPrefs.SetInt("ScreenMode", option);
        PlayerPrefs.Save();
    }
    public void CambiarSens(float valor)
    {
        sensi = valor;
        camxy.mouseSensitivity = sensi;

        // Guardar el valor en PlayerPrefs
        PlayerPrefs.SetFloat("Sens", sensi);
        PlayerPrefs.Save();
    }

    void ApplyScreenMode(int option)
    {
        if (option == 0)
        {
            Screen.fullScreen = true;
        }
        if(option == 1)
        {
            Screen.fullScreen = false;
        }
    }
void ChangeLanguage(int newLang)
{
    newLang = dt.lang = newLang;

    switch (newLang)
    {
        case 0: idioma = "ingles"; break;
        case 1: idioma = "español"; break;
        case 2: idioma = "frances"; break;
        case 3: idioma = "aleman"; break;
        case 4: idioma = "japones"; break;
        case 5: idioma = "portugues"; break;
        case 6: idioma = "ruso"; break;
        case 7: idioma = "italiano"; break;
        case 8: idioma = "coreano"; break;
        case 9: idioma = "chino"; break;
    }

    PlayerPrefs.SetInt("Language", newLang);
    PlayerPrefs.Save();
}
void OnUserChangedLanguage(int newLang)
{
    if (isInitializing) return;

    lang = newLang;
    UpdateTextosIdioma();
    PlayerPrefs.SetInt("Language", newLang);
    PlayerPrefs.Save();
}

void UpdateTextosIdioma()
{
    switch (lang)
    {
        case 0: idioma = "ingles"; break;
        case 1: idioma = "español"; break;
        case 2: idioma = "frances"; break;
        case 3: idioma = "aleman"; break;
        case 4: idioma = "japones"; break;
        case 5: idioma = "portugues"; break;
        case 6: idioma = "ruso"; break;
        case 7: idioma = "italiano"; break;
        case 8: idioma = "coreano"; break;
        case 9: idioma = "chino"; break;
    }
}
    void CambiarExposicion(float valor)
    {
            colorGrading.postExposure.value = valor;
            PlayerPrefs.SetFloat("Exposure", valor);
            PlayerPrefs.Save();
    }
    void t11()
    {
            if(games > 0)
            {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
            }
    home = play.home = home;
      home = false;
    camm.SetActive(true);
    canvi.SetActive(false);
    canvii.SetActive(true);
     Invoke("t2", 1f);
        if(newx == true || cont == true)
        {
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            0,
            0
        );
        playerx.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        }
        if(newx == true || cont == true)
        {
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            0,
            0
        );
        camerax.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        }
    }
    void t1()
    {
            texto.color = colorNormal;
            textoj.color = colorNormal;
            textok.color = colorNormal;
            textoc.color = colorNormal;
            textor.color = colorNormal;
    home = play.home = home;
      home = false;
PlayerPrefs.SetInt("Night", 1);
PlayerPrefs.Save();
    ng = PlayerPrefs.GetInt("Night", 1);
    camm.SetActive(true);
    canvi.SetActive(false);
    canvii.SetActive(true);
        if(newx == true || cont == true)
        {
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            0,
            0
        );
        playerx.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        }
        if(newx == true || cont == true)
        {
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            0,
            0
        );
        playerx.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        }

        if(newx == true || cont == true)
        {
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            0,
            0
        );
        camerax.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        }

     Invoke("t2", 1f);
    }
    void t2()
    {
     trans.SetActive(false);
    }
    void c3()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void t5()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void t15()
    {
    home = play.home = home;
      home = false;
    camm.SetActive(true);
    canvi.SetActive(false);
    canvii.SetActive(true);
     Invoke("t2", 1f);
        skip = 0;
        PlayerPrefs.SetInt("Skp", skip);
        PlayerPrefs.Save();
    skip = PlayerPrefs.GetInt("Skp", 0);
    }
}
