using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
#region Intialization and Uodate()
	public Text t;
	private enum States{cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, corridor_1, corridor_2, corridor_3,
						stairs_0, stairs_1, stairs_2, closet_door, in_closet, floor, courtyard};
	private States myState;
	void Start () {
		myState = States.cell;
	}
	void Update () {
		print (myState);
		if 		(myState == States.cell)			{state_cell();}
		else if (myState == States.sheets_0)		{state_sheets_0();}
		else if (myState == States.lock_0)			{state_lock_0();}
		else if (myState == States.mirror)			{state_mirror ();}
		else if (myState == States.cell_mirror)		{state_cell_mirror();}
		else if (myState == States.sheets_1)		{state_sheets_1();}
		else if (myState == States.lock_1)			{state_lock_1();}
		else if (myState == States.corridor_0)		{state_corridor_0();}
		else if (myState == States.corridor_1)		{state_corridor_1();}
		else if (myState == States.corridor_2) 		{state_corridor_2();}
		else if (myState == States.corridor_3)		{state_corridor_3();}
		else if (myState == States.stairs_0)		{state_stairs_0();}
		else if (myState == States.stairs_1)		{state_stairs_1();}
		else if (myState == States.stairs_2)		{state_stairs_2();}
		else if (myState == States.closet_door)		{state_closet_door();}
		else if (myState == States.in_closet)		{state_in_closet();}
		else if (myState == States.floor)			{state_floor();}
		else if (myState == States.courtyard)		{state_courtyard();}
	}	
#endregion
#region State Handlers
	void state_cell(){
		t.text = "You got put in jail for life because you killed your whole family after smoking a marijuana cigarette, and you want to escape. Right now you're in a cell. There are " +
				 "some dirty sheets on the bed, a mirror on the wall, and the door that " + 
				 "is locked from the outside.\n\n" +
				 "Press S to look at the sheets \nPress M to go to the mirror \nPress D to go to the door";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.D))	{myState = States.lock_0;}
	}		
	void state_sheets_0(){
		t.text = "These sheets are gross.. Smoking so many marijuana cigarettes caused you to lose control of your bladder every night. Theres not really a lot to do with the sheets right now. \n\nPress R to try something else";
		
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	void state_lock_0(){
		t.text = "You just want to get out to do more marijuana cigarettes and kill more families! There must be a way to get this lock open.. \n\nPress R to try something else";
		
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	void state_mirror(){
		t.text = "You look like shit.. Probably from all the ass raping that has been happening to you in here..."  +
				 "\n\nPress R to try something else\nPress B to break the mirror out of self pity.";
				 
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.cell_mirror;}
	}
	void state_cell_mirror(){
		t.text = "Well that was stupid, now your hand is bleeding.. Oh well, maybe you can stab somebody with that shard of mirror." +
				 "\n\nPress S to go to the sheets\nPress D to go to the door";
				 
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.D))	{myState = States.lock_1;}
	}
	void state_sheets_1(){
		t.text = "You wiped the blood from your hand on to the sheets. Only probably is now your hand smells like pee. Idiot. \n\nPress R to return";
		
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_mirror;}
	}
	void state_lock_1(){
		t.text = "You guess you could try and pick the lock with the glass. (That makes total sense right? Glass is indestructable)" +
				 "\n\nPress R to return \nPress P to pick the lock";
				 
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.P))	{myState = States.corridor_0;}
	}
	void state_corridor_0(){
		t.text = "Awesome, it worked, you're in the corridor. Now you just have to get out of the complex.." +
				 "\nYou see a closet, some stairs, and a dirty floor" +
				 "\n\nPress C to check the closet for marijuana cigarettes\nPress S to go upstairs to find marijuana cigarettes\nPress F to try and find a marijuana cigarette on the floor";
				 
		if 		(Input.GetKeyDown(KeyCode.C))	{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.floor;}
	}
	void state_stairs_0(){
		t.text = "Your Big Daddy lives upstairs... Better stay away from there if you can." +
			"\n\nPress R to return to the corridor";
		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.corridor_0;}
	}
	void state_closet_door(){
		t.text = "The door is locked. In prison. Go figure." +
			"\n\nPress R to return to the corridor";
		
		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.corridor_0;}
	}
	void state_floor(){
		t.text = "This floor is gross. No marijuana cigarettes.. There's a hairclip on the ground though, in case you want to put your hair up or something." +
			"\n\nPress R to return to the corridor\nPress H to pick up the gross ass hairclip";
		
		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.H)) 	{myState = States.corridor_1;}
	}
	void state_corridor_1(){
		t.text = "Big Daddy might like this hairclip thing.. Or you could unlock the closet with it" +
				 "\n\nPress S to go up the stairs to see Big Daddy\nPress C to unlock the closet";
				 
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_1;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.in_closet;}
	}
	void state_stairs_1(){
		t.text = "Big Daddy shoved the hair clip in your ass! You got it out, but still. Maybe you shouldn't go see him anymore... Or maybe you should" +
			"\n\nPress R to go back down stairs";
		
		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.corridor_1;}
	}
	void state_in_closet(){
		t.text = "Okay, you're in the closet. It's full of janitor uniforms.. You could probably put one on and sneek out to the courtyard.." +
			"\n\nPress R to leave the closet\nPress J to get dressed, and then leave the closet.";
		
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_2;}
		else if (Input.GetKeyDown(KeyCode.J)) 	{myState = States.corridor_3;} 
	}
	void state_corridor_2(){
		t.text = "Shit, a guard is out there now.\n\nPress R to go back in to the closet, fag";
		
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.in_closet;}
	}
	void state_corridor_3(){
		t.text = "Sweet, the guards don't even notice you now that you're in a janitor uniform. Because thats how games work. You're pretty much home free now. " + 
				 "You could go up the stairs and rub your success in Big Daddy's face, or you could get the fuck out of here." + 
				 "\n\nPress S to go up stairs and rub your success in Big Daddy's face\nPress F to leave the prison and never come back";
				 
		if 		(Input.GetKeyDown(KeyCode.S)) 	{myState = States.stairs_2;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.courtyard;};
	}
	void state_stairs_2(){
		t.text = "Big Daddy did not take kindly to your verbal abuse.. He called a guard, and the guard put you in Big Daddy's cell. " +
				 "From there, you were raped multiple times and died from the abuse." +
				 "\n\n You... uh.. win?\n\nPress P to play again";
				 
		if 		(Input.GetKeyDown(KeyCode.P)) 	{Start ();}
	}
	void state_courtyard(){
		t.text = "Bye Bitches. Your life still kinda sucked, because of being on the run for the rest of your life and all.. But whatever, now you can smoke more marijuana cigarettes and kill more families." +
				 "\n\n You Win(ish)!\n\n Press P to play again";
				 
		if 		(Input.GetKeyDown(KeyCode.P)) 	{Start();}
	}
#endregion
}
