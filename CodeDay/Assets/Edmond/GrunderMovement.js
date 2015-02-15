#pragma strict

	var right : Animator;
	var left: Animator;
	var particles : GameObject;
	private var particleclone : GameObject;
	private var particleclone2 : GameObject;
	var leftObject : GameObject;
	var rightObject : GameObject;
	private var leftTransform : Transform;
	private var rightTransform : Transform;
	private var enemySpawn : boolean = false;
	var spawnTimer : float = 3f;
	var enemyOne : GameObject;
	private var enemyOneClone : GameObject;
	public static var thing : boolean = false;
	
	function EnemySpawn () {
	while (enemySpawn == true) {
	enemyOneClone = Instantiate (enemyOne, new Vector3 (0.25f, 1f, -1f), Quaternion.identity);
	yield WaitForSeconds (spawnTimer);
	}
	}
	
	function OnCollisionEnter (other : Collision) {
	
	Application.LoadLevel("Game Over");
	
	}

	function OnTriggerEnter () {
		right.Play ("RightPart");
		left.Play ("LeftPart");
		leftTransform  = leftObject.GetComponent(Transform);
		rightTransform = rightObject.GetComponent(Transform);
		yield WaitForSeconds (0.5f);
		particleclone = Instantiate (particles, leftTransform.position - new Vector3 (0.25f, -0.75f, 0f), Quaternion.Euler (0f, 90f, 0f));
		particleclone2 = Instantiate (particles, rightTransform.position - new Vector3 (-0.23f, 0.65f, 0f), Quaternion.Euler (0f, 270f, 0f));
		enemySpawn = true;
		EnemySpawn();
	}