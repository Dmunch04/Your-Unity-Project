using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeandate : MonoBehaviour
{
    public static int month = 1;
    public static int year = 1;
    public static int week = 1;
    public static int framesPerWeek = 100;
    private static int weekIncrementTimer;
    public static int money = 1000;
    public static int rent = 50;
    public static int fans = 0;
    public static int pendingProfit = 0;
    public static int pendingFans = 0;
    public bool autoPlay = false;
    public static int bankruptoffers = 3;
    public static int warnings = 0;
    public bool autoPlaymedium = false;
    public static int loanmoney = 0;
    public bool detuctmoneytest = false;
    public GameObject LoanDisplayScreenUI;
    public static int LoadNumber = 0;
    public static bool gameisstopped = false;
    public GameObject BankruptcyDisplayScreenUI;
    public static int loansoundnumber = 3;
    public static int researchPoints = 0;
    public static int pendingResearchPoints = 0;
    public int level = 1; 

    public AudioClip LoanOfferSound;
    public AudioClip Bankruptsound;

    public Text rentDisplayText;
    public Text profitDisplayText;
    public Text pfansDisplayText;
    public Text BankruptOfferText;

    static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    private void Update()
    {
           if (gameisstopped == false) {
            LoanDisplayScreenUI.SetActive(false);
            BankruptcyDisplayScreenUI.SetActive(false);
            GetComponent("RentDisplay.cs");
            bankruptoffers = 3;
            Debug.Log("bank offers left =" + bankruptoffers);

             

            if (weekIncrementTimer >= framesPerWeek)
                {
                    weekIncrementTimer = 0;
                    week++;
                    Debug.Log("Week =" + week);
                    if (week >= 5)
                    {
                        week = 1;
                        money -= rent;
                        StartCoroutine(DisplayRentTaken(rent));
                        StartCoroutine(DisplayProfitAdded(pendingProfit));
                        StartCoroutine(DisplayFansAdded(pendingFans));
                        money = money + pendingProfit;
                        fans = fans + pendingFans;
                        researchPoints = researchPoints + pendingResearchPoints;
                        month++;
                        Bankruptchecker();
                        Debug.Log("month =" + month);
                        if (month >= 13)
                        {
                            month = 1;
                            year++;
                            Debug.Log("year =" + year);
                        }

                    }
                }

                else

                {
                    weekIncrementTimer++;
                }



            if (autoPlay == false)
            {
                // do nothing		
            }
            if (autoPlay == true)
            {
                PlayAuto();
            }

            if (autoPlaymedium == false)
            {
                // do nothing       
            }
            if (autoPlaymedium == true)
            {
                PlayMedAuto();
            }
            if (detuctmoneytest == false)
            {
                // do nothing       
            }
            if (detuctmoneytest == true)
            {
                MoneyDetuctTest();
            }

        }
        if (gameisstopped == true) {


        }
    }


    IEnumerator DisplayRentTaken(int rent)
    {
        rentDisplayText.gameObject.SetActive(true);
        rentDisplayText.text = "Rent taken: -£ " + rent;
        yield return new WaitForSeconds(2f);
        rentDisplayText.gameObject.SetActive(false);
    }
    // displays the rent in game

    IEnumerator DisplayProfitAdded(int pendingProfit)
    {
        profitDisplayText.gameObject.SetActive(true);
        profitDisplayText.text = "Income: +£ " + pendingProfit;
        yield return new WaitForSeconds(2f);
        profitDisplayText.gameObject.SetActive(false);
    }
    // displays the pedning profit in game

    IEnumerator DisplayFansAdded(int pendingFans)
    {
        pfansDisplayText.gameObject.SetActive(true);
        pfansDisplayText.text = "Fans: + " + pendingFans;
        yield return new WaitForSeconds(2f);
        pfansDisplayText.gameObject.SetActive(false);
    }
    // displays the pedning fans in game

    public static void Reset()
    {
        week = 1;
        month = 1;
        year = 1;
        weekIncrementTimer = 0;
        money = 50;
        fans = 0;
        pendingFans = 0;
        pendingProfit = 0;
        framesPerWeek = 100;
        bankruptoffers = 3;
        warnings = 0;
        LoadNumber = 0;
        gameisstopped = false;
        loansoundnumber = 3;
    }

    public void PlayAuto()
    {
        framesPerWeek = 1;
    }

    public void PlayMedAuto()
    {
        framesPerWeek = 50;
    }

    public void Bankrupt()
    {
        BankruptcyDisplayScreenUI.SetActive(true);
        AudioSource.PlayClipAtPoint(Bankruptsound, transform.position);
        Debug.Log("bankruptcy declared for: ");
        gameisstopped = true;


    }
    public void Bankruptchecker()
    {

        if (money < 0)
        {
            Debug.Log("money is below 0");
            warnings++;
            Debug.Log("Warnings" + warnings);

            if (warnings >= 3)
            {
                Debug.Log("Max warnings exceeded, loading loan");
                LoanOffer();
            }

            else if (money > 0)
            {
                warnings = 0;
                Debug.Log("warnings set to 0");
                //resets the month calculator
            }
        }
    }

    private void LoanOffer() {
       
        if (LoadNumber == 0) {


               
                Debug.Log("creating first loan offer");
                LoanOfferDisplay();
                bankruptoffers = 2;
                BankruptOfferText.text = "2";
            }



        if (LoadNumber == 1)
        {


            Debug.Log("creating second loan offer");
            LoanOfferDisplay();
            bankruptoffers = 1;
            BankruptOfferText.text = "1";
        }
           

        if (LoadNumber == 2)
        {
           
               
                Debug.Log("creating final loan offer");
                LoanOfferDisplay();
                bankruptoffers = 0;
                BankruptOfferText.text = "0";
            }
           


        if (LoadNumber > 3) {
            Bankrupt();
        }
        if (warnings > 3)
        {
            Bankrupt();
        }

        else { } //nothing happens

    }
         public void MoneyDetuctTest() {
                     money = money - 1000;
    }

    public void LoanOfferDisplay()
        {
        if (loansoundnumber > 0)
        {
            AudioSource.PlayClipAtPoint(LoanOfferSound, transform.position);
        }

            gameisstopped = true;
            Time.timeScale = 0.01f;
            LoanDisplayScreenUI.SetActive(true);
            Debug.Log("Load Loan Display");

        }

    public void LoanAccepted ()
        {
            gameisstopped = false;
            LoanDisplayScreenUI.SetActive(false);
            Time.timeScale = 1f;
            pendingProfit = loanmoney = 10000;
            money = money + loanmoney;
            Debug.Log("loan money sent");
            pendingProfit = loanmoney = 0;
            LoadNumber = LoadNumber + 1;
            Debug.Log("LoadNumber" + LoadNumber);
            warnings = 0;
            loansoundnumber = loansoundnumber - 1;
        }
    public void LoanDeclined () {
            LoanDisplayScreenUI.SetActive(false);
            Time.timeScale = 1f;
            gameisstopped = false;
            
    }

    public void BankruptAgreed () {
        
                Reset();
                Debug.Log("Player has lost, loading reason screen");
                BankruptcyDisplayScreenUI.SetActive(false);
                Time.timeScale = 1f;

    }
    public void BankruptLoadLevelRequest() {
        
                Reset();
                Debug.Log("Player has lost, loading load level screen");
                BankruptcyDisplayScreenUI.SetActive(false);
                Time.timeScale = 1f;
        }
    public void BankruptImage () {
        Bankrupt();

    }

	}

