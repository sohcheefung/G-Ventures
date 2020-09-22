using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
	
	public Animator animator;
	
	public static bool GameIsOver = false;
	public GameObject gameOverUI;
	
	public float runSpeed = 40f;
	float horizontalMove = 0f;
	
    bool jump = false;
	bool crouch = false;
	
	public float knockback;
	public float knockbackLength;
	public float knockbackCount;
	public bool knockFromRight;
	
	private Rigidbody2D rb2d;
	
	//Player Health
	public int curHealth;
	public int maxHealth = 5;
	public GameObject blood;
	public GameObject player;
	
	public GameObject floatingPointsGood;
	public GameObject floatingPointsBad;
	
	
	void Start()
	{
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		curHealth = maxHealth;
		Time.timeScale = 1;
	}
	
	public void displayPointsGood()
	{
		Instantiate(floatingPointsGood, transform.position, Quaternion.identity);
	}
	
	public void displayPointsBad()
	{
		Instantiate(floatingPointsBad, transform.position, Quaternion.identity);
	}
	
	private void Die()
	{
		Destroy(player);
		Instantiate (blood, transform.position, Quaternion.identity);
		GameIsOver = true;
		gameOverUI.SetActive(true);
	}
	
	
	public void Damage(int dmg){
	
		curHealth -= dmg;
		gameObject.GetComponent<Animation>().Play("player_hurt");
	}
	
    // Update is called once per frame
    void Update()
    {
        horizontalMove = CrossPlatformInputManager.GetAxis("Horizontal")* runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		if (CrossPlatformInputManager.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("isJumping", true);
		}
		if (CrossPlatformInputManager.GetButtonDown("Crouch"))
		{
			crouch = true;
		}else if (CrossPlatformInputManager.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
		if(curHealth > maxHealth){
			curHealth = maxHealth;
		}
		if(curHealth <=0){
			Die();
			}
			
		if(knockbackCount <= 0)
		{
			rb2d.velocity = new Vector2(horizontalMove, rb2d.velocity.y);
		}else{
			if(knockFromRight)
				rb2d.velocity = new Vector2(-knockback, knockback);
			if(!knockFromRight)
				rb2d.velocity = new Vector2(knockback, knockback);
			knockbackCount -= Time.deltaTime;
		}
	}
	
	public void OnLanding (){
		animator.SetBool("isJumping", false);
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("platform"))
			this.transform.parent = col.transform;
	}
	
	void OnCollisionExit2D(Collision2D col)
	{
		if(col.gameObject.CompareTag("platform"))
			this.transform.parent = null;
		
	}
	 
	public void OnCrouching (bool isCrouching){
		animator.SetBool("isCrouching", isCrouching);
	}
	
	void FixedUpdate ()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
		
	}
}
