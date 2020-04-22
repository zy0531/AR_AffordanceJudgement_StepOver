# AR_AffordanceJudgement_StepOver

## Introduction
This project is to explore human affordance judgement in mobile AR and how cognitive cue influence affordance judgement in Real World and in AR condition.  

<img src="https://github.com/zy0531/AR_AffordanceJudgement_StepOver/blob/master/ScreenShot/trial%20procedure.png" width="550" height="300"/>

This is a preliminary experiment to figure out how the cues of step size impact the affordance judgement of stepping over the gap. Specifically, participants are instructed to adjust the gap width in front of them until they thought it is the larget width that they could step over by one step size. This is a between-subject experiment. Each group of subjects are given a cue with the size of a ratio to his/her step size. The ratios are 0.8, 1.0 and 1.2. The cue in the figure below is a circle aligning to the floor with radius of step size and its center is the xy-position of camera, representing the participant’s capability of stepping . 

<img src="https://github.com/zy0531/AR_AffordanceJudgement_StepOver/blob/master/ScreenShot/Screenshot3.jpg" width="150" height="300"/>

In a set of trials for one subject, he/she is first asked to complete a block of perception experience trials (PET) that consisted of four affordance judgment trials. The four affordance judgment trials consist of 2“ascending”(A) and2“descending”(D) trials, always following the same pattern: A, D, A and D. In the ascending trials, the gap width started small (70% participants’ step size); In the descending trials, participants were presented with a large gap (140% participants’ step size). 

Then participants are presented with outcome experience trial (OET) blocks by being given the cue. The trial procedure is the same in OET which includes four affordance judgment trials in order of A, D, A, and D.

This primary user study is to find whether there is any difference of affordance judgement when the subjects are given different cues.

## Platform
Unity 2019.2.21f1

Android 9

ARCore SDK 1.15.0

## Interaction
*1. Start the App*

Hold the smart phone upright and start the app. 

*2. Input Maximum Step Size*

Input your Maximum Step Size on upper left corner. Click on button "OK" to confirm your input.

<img src="https://github.com/zy0531/AR_AffordanceJudgement_StepOver/blob/master/ScreenShot/Screenshot1.jpg" width="150" height="300"/>

*3. Detect Surface*

Scan the environment and there will be blue and white spots on the floor when the system detects that surface. Hit a specific point on the floor and a blue virtual gap will show up on the point with the same x and y coordinate of your hit, near your feet. The width of the gap depends on your input step size. The gap starts with small width then large width.

<img src="https://github.com/zy0531/AR_AffordanceJudgement_StepOver/blob/master/ScreenShot/Screenshot2.jpg" width="150" height="300"/>

*4. Change Gap Width*

Click on 'Narrow' or 'Widen' button to make the gap change 5cm increments narrower or wider every single time. You can click the button 'Go!' when you think you have adjusted the gap width to right let you step over with your biggest capability. System will show "[Trial #] Please hit the the ground to continue the trial."

*5. Show the Cue*

When it comes to the 4th trial, there will show up a transparent circle with your step size showing under your feet. You can use that as a cue to help you estimate the maximum gap you are able to step over.

<img src="https://github.com/zy0531/AR_AffordanceJudgement_StepOver/blob/master/ScreenShot/Screenshot4.jpg" width="150" height="300"/>

*6. Finish*

When you complete all trials, The system will show "You've finished all trials :)" 

*7. Record the Experiment Data*

This App uses "Application.persistentDataPath" to record the experiment data.  "Application.persistentDataPath" points to points to a public directory on the device(eg./storage/emulated/0/Android/data/<packagename>/files on most devices). Files in this location are not erased by app updates. The files can still be erased by users directly. [In our case, the data can be find in, when connecting a computer, This PC\Galaxy S8\Phone\Android\data\com.DefaultCompany.AJStepOver.]
  
<img src="https://github.com/zy0531/AR_AffordanceJudgement_StepOver/blob/master/ScreenShot/data.PNG" width="300" height="100"/>

## Demo Video
A whole process of this experiment.
https://drive.google.com/file/d/1KquHwXW6KtMTtIGB7kXhiu2w7woc9hJC/view?usp=sharing
