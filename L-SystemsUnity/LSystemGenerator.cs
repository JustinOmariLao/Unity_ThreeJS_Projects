using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LSystemGenerator : MonoBehaviour {
    private string axiom = "A";
    private float angle;
    private string currentString;
    private Dictionary<char, string> rules = new Dictionary<char, string>();
    private Stack<TransformInfo> transformStack = new Stack<TransformInfo>();

    private float length;
    private bool isGenerating = false;

    // Start is called before the first frame update
    void Start()
    {
        rules.Add('A', "B-A-B");
        rules.Add('B', "A+B+A");
        currentString = axiom;
        angle = 60f;
        length = 4f;

        StartCoroutine(GenerateLSystem());
    }

    // Update is called once per frame
    void Update() {
        
    }

    IEnumerator GenerateLSystem()
    {
        int count = 0;
        while (count < 4)
        {
            if (!isGenerating)
            {
                isGenerating = true;
                StartCoroutine(Generate());
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    IEnumerator Generate() {
        length = length / 2f;
        string newString = "";

        char[] stringCharacters = currentString.ToCharArray();

        for (int i = 0; i < stringCharacters.Length; i++) {
            char currentCharacter = stringCharacters[i];

            if (rules.ContainsKey(currentCharacter)) {
                newString += rules[currentCharacter];
            }   
            else {
                newString += currentCharacter.ToString();
            }
        }

        currentString = newString;
        UnityEngine.Debug.Log(currentString);

        stringCharacters = currentString.ToCharArray();

        for(int i = 0; i < stringCharacters.Length; i++) {
            char currentCharacter = stringCharacters[i];

            if (currentCharacter == 'A' || currentCharacter == 'B') {
                Vector3 initialPosition = transform.position;
                transform.Translate(Vector3.forward * length);
                UnityEngine.Debug.DrawLine(initialPosition, transform.position, Color.white, 10000f, false);
                yield return null;
            }
            else if (currentCharacter == '+') {
                transform.Rotate(Vector3.up * angle);
            }
            else if (currentCharacter == '-') {
                transform.Rotate(Vector3.up * -angle);
            }
        }
        isGenerating = false;
    }
}
