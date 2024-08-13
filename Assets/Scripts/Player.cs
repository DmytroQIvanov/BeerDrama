using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public float moveSpeed = 30f;
    public float jumpSpeed = 150f;
    public float rotateSpeed = 75f;

    public Text LifeTextObj,BeerBottleTextObj;
    public int LifeCount = 3,CoinCount=0;
    public Animator PlayerAnimator;
    public Text CoinTextObj;

    public GameObject LeftBtn,RightBtn,JumpBtn,BeerBottlePrefab;

    private Rigidbody2D _rb;
    private Vector2 velocity;
    private SpriteRenderer spriteRenderer;

    private bool rightM, leftM, jumpM, downM,onGround = false;
    public bool doubleJump ;
    public int jumpCount=0;
    private float moving;


    public AudioSource HitSource;
    public AudioClip HitClip,RunClip,JumpClip,CoinClip,OnGroundClip,DamageClip;
    

    public int beerBottle =0;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        LifeTextObj.text = "Жизни: "+LifeCount;
        spriteRenderer = GetComponent<SpriteRenderer>();

        //LeftBtn.onClick.AddListener(LeftBtnF);
        //RightBtn.onClick.AddListener(RightBtnF);
      //  JumpBtn.AddComponent<JumpBtnF>();

    }
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || JumpBtn.GetComponent<ControlBTN>().btnPressed)
        {
            JumpBtnF();
        }
        else {
         //   jumpM = false;
        }
        if (Input.GetKeyDown(KeyCode.S)) {

            downM = true;
        }
            else 
            {
            //downM = false;
            }
        if (leftM || rightM)
        {
          PlayerAnimator.SetFloat("Speed", 1);
        }
        else
        {

           PlayerAnimator.SetFloat("Speed", 0);
        }
        
        if (Input.GetKey(KeyCode.A) || LeftBtn.GetComponent<ControlBTN>().btnPressed) {
            
      
            leftM = true;
            spriteRenderer.flipX = true;
        }
            else 
        {
            leftM = false;
         

            }
        if (Input.GetKey(KeyCode.D) || RightBtn.GetComponent<ControlBTN>().btnPressed) {
            rightM = true;
            spriteRenderer.flipX = false;

        }
        else 
            {
            rightM = false;
            };

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("ANIIIM");
            HitF();
            
        }
    }
    private void OnMouseDown()
    {
        
    }


    void FixedUpdate()
    {
        if (moving!=0) {
            _rb.AddForce(new Vector2(moveSpeed * moving * Time.deltaTime, 0), ForceMode2D.Impulse);
        }
        if (jumpM)
        {

            _rb.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
            jumpM = false;
            }
        if (rightM)
        {

            _rb.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);
        }
        if(leftM)
        {

            _rb.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);

        }
        if (downM) {

            _rb.AddForce(new Vector2(0f, -jumpSpeed * Time.deltaTime), ForceMode2D.Impulse);
        }
       
        
 }
void OnTriggerEnter(Collider other) {
 
        LifeCount -= 1;
        LifeTextObj.text = "Жизни: " + LifeCount;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            HitSource.PlayOneShot(CoinClip);
            CoinCount += 1;
            CoinTextObj.text = "Монетки: " + CoinCount;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "danger")
        {
            LifeCount -= 1;
            LifeTextObj.text = "Жизни: " + LifeCount;
            HitSource.PlayOneShot(DamageClip);
            if (LifeCount ==0 || LifeCount < 0)
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
            } 
        }
        if (collision.gameObject.tag == "beerBottle")
        {
            beerBottle += 1;
            Destroy(collision.gameObject);
            BeerBottleTextObj.text = "" + beerBottle;

        }


    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "ground")
        {
            PlayerAnimator.SetBool("Jump", false);
            onGround = true;
            HitSource.PlayOneShot(OnGroundClip);
            jumpCount=0;
        }

        //LifeCount -= 1;
        //LifeTextObj.text = "Жизни: " + LifeCount;
        // onGround=true;
        //Destroy(col.gameObject.);
        // Debug.Log(col.gameObject.name);
        // Debug.Log("----------OnCollisionEnter2D");
    }
    public void RemoveLife()
    {
        Debug.Log("Remove" + LifeCount);
        LifeCount -= 1;
        LifeTextObj.text = "Жизни: " + LifeCount;

    }
    public void HitF()
    {
        //HitSoundF();
        if(beerBottle >0) BeerAtackF();
        BeerBottleTextObj.text = "" + beerBottle;
        PlayerAnimator.SetTrigger("Hit");


    }
    void LeftBtnF()
    {

    }

    void RightBtnF()
    {

    }

    public void JumpBtnF()
    {

        
        if(!onGround && !doubleJump) return;
        if(!onGround && jumpCount >=1 && !doubleJump)return;
        if(!onGround && jumpCount >=2 && doubleJump)return;
        // if( && jumpCount>=2)) ;
        PlayerAnimator.SetBool("Jump",true);
        onGround = false;
        jumpM = true;
        if(doubleJump && jumpCount<2){
            ++jumpCount;
        }


    }

    void HitSoundF()
    {
        HitSource.PlayOneShot(HitClip);
    }
    void RunSoundF()
    {
        HitSource.PlayOneShot(RunClip);
    }
    void JumpSoundF()
    {
        HitSource.PlayOneShot(JumpClip);
    }
    void BeerAtackF()
    {
        beerBottle -= 1;
        GameObject beerBottleClone;

        Vector2 customVector;
        if (spriteRenderer.flipX)
        {
            customVector = Vector2.left * 20;
        }
        else
        {
            customVector = Vector2.right * 20;

        }
        Vector2 PlayerPos;
        if (spriteRenderer.flipX)
        {
            PlayerPos = new Vector2(gameObject.transform.position.x - 1, gameObject.transform.position.y);
        }
        else
        {
            PlayerPos = new Vector2(gameObject.transform.position.x + 1, gameObject.transform.position.y);


        }
        beerBottleClone = Instantiate(BeerBottlePrefab, PlayerPos, Quaternion.identity);
        Rigidbody2D beerBottleRigidbody2D = beerBottleClone.GetComponent<Rigidbody2D>();
        beerBottleRigidbody2D.velocity = transform.TransformDirection(customVector);

    }


}
