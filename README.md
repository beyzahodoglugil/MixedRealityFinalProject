# MixedRealityFinalProject
Intorduction to Mixed Reality Applications | Final Assignment

## 🌿 Scenario: The Living Ecosystem (Animals & Nature)

The project implements the **Living Ecosystem** scenario defined in the course specification.  
An interactive nature scene is created where users engage with virtual animals using **hand-based touchless interaction**.

---

## 🦋 Object 1: Butterfly Cocoon → Butterfly Transformation
- A **3D Butterfly Cocoon** is placed in the scene.
- When the user’s hand enters the cocoon’s interaction area, the cocoon **opens** and a **3D Butterfly appears**.
- **Wing-flapping sound effects** are triggered to provide audio feedback.
- Interaction is detected using **index finger tip tracking** and **collider-based event logic**.

---

## 🤖 Object 2: Doraemon-Style Character (Greeting Interaction)
- A **3D Doraemon-style character** is positioned in the environment.
- When the user interacts with the character using hand gestures:
  - A **greeting message** appears on a 3D world-space panel.
  - A **friendly robot-style voice** plays a greeting audio.
- This interaction combines **visual and audio feedback** for a more engaging experience.
  
  > Note: An original robot-style voice is used instead of an original character voice to avoid copyright issues.

---

## 🐶 Object 3: Dog Interaction (Bone & Bark)
- A **3D Dog** is placed on the virtual ground.
- When the user touches the dog using hand interaction:
  - A **bone object appears** in front of the dog.
  - A **dog barking sound effect** is triggered.
- This interaction demonstrates a **cause-and-effect relationship** between physical gestures and digital responses.

---

## 🧠 Technical Architecture

### Skeleton Tracking
- **MediaPipe** is used for real-time **hand landmark detection** via the **computer webcam**.
- Key tracked joints include:
  - Wrist  
  - Index Finger Tip  

### Interaction Logic (Bounding Boxes)
- Each interactive object is surrounded by a **Bounding Box (Collider)**.
- When a tracked hand landmark enters a collider:
  - An interaction event is triggered using **OnTriggerEnter** logic.
- This event-based approach ensures **accurate and responsive touchless interaction**.

### 3D Content
- The scene includes multiple **dynamic 3D objects**:
  - Butterfly Cocoon
  - Butterfly
  - Doraemon-style character
  - Dog
  - Bone
- All interactions occur within a fully **3D Unity environment**.

---

## 🎧 Feedback Mechanisms

- **Visual Feedback**
  - Object appearance and disappearance
  - World-space text panels
- **Audio Feedback**
  - Butterfly wing flapping sounds
  - Friendly robot greeting voice
  - Dog barking sound

These feedback mechanisms enhance user engagement and interaction clarity.

---

## 🛠️ Technologies Used
- **Unity 3D (2022 LTS)**
- **MediaPipe (Hand Tracking)**
- **C#**
- **TextMeshPro**
- **Collider-based Event System**
- **Computer Webcam Input**

---

## 📂 How to Run
1. Clone or download the repository.
2. Open the project using **Unity Hub**.
3. Ensure a **webcam** is connected and accessible.
4. Press **Play** to start the touchless interaction system.

---
