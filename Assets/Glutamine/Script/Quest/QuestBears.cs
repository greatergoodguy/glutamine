using UnityEngine;
using System.Collections;

public class QuestBears : MonoBehaviour {

	private static readonly float TOTAL_DURATION = 7.0f;
	private static readonly int ACCUMULATOR_NUM = 4;

	float elapsedTime = 0;
	bool isStarted = false;
	bool isFinished = false;

	int accumulator = 0;

	GameObject goPapa;
	GameObject goMama;
	GameObject goBaby;

	void Awake() {
		goPapa = transform.FindChild("Bears/Papa Bear").gameObject;
		goMama = transform.FindChild("Bears/Mama Bear").gameObject;
		goBaby = transform.FindChild("Bears/Baby Bear").gameObject;
	}

	void Update() {
		if(!isStarted) {
			return;
		}

		if(isFinished) {
			return;
		}

		elapsedTime += Time.deltaTime;
		if(elapsedTime > TOTAL_DURATION) {
			QuestFinish();
		}
	}

	public void QuestFinish() {
		isFinished = true;

		Destroy (goPapa.GetComponent<GeneFollowHero>());
		goPapa.transform.eulerAngles = Vector3.zero;
		GeneSpeech speechPapa = goPapa.AddComponent<GeneSpeech>();
		speechPapa.text = "Why you steal my apples!!";
		
		Destroy (goMama.GetComponent<GeneFollowHero>());
		goMama.transform.eulerAngles = Vector3.zero;
		GeneSpeech speechMama = goMama.AddComponent<GeneSpeech>();
		speechMama.text = "My husband lost 1000 lbs";
		
		Destroy (goBaby.GetComponent<GeneFollowHero>());
		goBaby.transform.eulerAngles = Vector3.zero;
		GeneSpeech speechBaby = goBaby.AddComponent<GeneSpeech>();
		speechBaby.text = "Why doesn't my mom use the metric system? That's so backwards";
		speechBaby.size = GeneSpeech.Size.Medium;

		Reset();
	}

	void Reset() {
		elapsedTime = 0;
		isStarted = false;
		isFinished = false;
		
		accumulator = 0;
	}

	public void Activate() {
		if(isStarted) {
			return;
		}

		accumulator += 1;

		if(accumulator >= ACCUMULATOR_NUM) {
			QuestStart();
		}
	}

	private void QuestStart() {
		isStarted = true;
		Destroy (goPapa.GetComponent<GeneSpeech>());
		GeneFollowHero genePapa = goPapa.AddComponent<GeneFollowHero>();
		genePapa.speed = 6.4f;

		Destroy (goMama.GetComponent<GeneSpeech>());
		GeneFollowHero geneMama = goMama.AddComponent<GeneFollowHero>();
		geneMama.speed = 0.4f;

		Destroy (goBaby.GetComponent<GeneSpeech>());
		GeneFollowHero geneBaby = goBaby.AddComponent<GeneFollowHero>();
		geneBaby.speed = 2.8f;
	}
}
