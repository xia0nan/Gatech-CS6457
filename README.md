# Gatech-CS6457
CS6457 Video Game Design Repo

Unity 3D Installation
=====================

Even if you are familiar with the Unity 3D Engine, please review the following information.

This course uses the Unity 3D Engine for most assignments. It's important that you install the correct version and test it out before you begin the class.

**Required Unity Version for Individual Milestones:**

2020.3.16f1 (LTS)

Make sure that you install this specific version and use it on your assignments!

**Required Unity Version for Team Project:**

Sticking with the above version is highly recommended. However, for the team project any stable (non-alpha/non-experimental) version of Unity greater than or equal to the version above is allowed.

**Supported Computing Platforms for the Class:**

The Video Game Design class specifies the same technical requirements as the on-campus and OMSCS program:

[https://sco.gatech.edu/hardware-requirements/ (Links to an external site.)](https://sco.gatech.edu/hardware-requirements/)

[https://omscs.gatech.edu/technical-requirements (Links to an external site.)](https://omscs.gatech.edu/technical-requirements)

This means you should have either a Windows 10 (or better) or MacOS (10.12.5 or better) computer.

Non x86 platforms such as the new ARM based Macs (M1) are ***not*** officially supported. Neither is Linux OS. That said, if you get a non-compliant platform to work with online class resources (Canvas, etc.) and the Unity 3D Engine (version above) then you may be able to successfully complete the course. However, be aware that technical problems related to your platform may pop up at a later date! Be prepared to resolve issues related to unsupported platforms including possibly buying/borrowing supported hardware if problems arise.

**Website:** 

[http://unity3d.com/ (Links to an external site.)](http://unity3d.com/)

**Installation**:

Go to the following site and choose "Download Unity Hub". If you have previously installed without Unity Hub, it is highly recommended that you switch to using Unity Hub. 

[https://unity3d.com/get-unity/download (Links to an external site.)](https://unity3d.com/get-unity/download)

Many students obtain a Personal license however you might consider applying for Unity Student as well ([https://store.unity.com/academic/unity-student (Links to an external site.)](https://store.unity.com/academic/unity-student)). You can start with Personal while waiting for approval.

Once you install Unity Hub, go to the "Installs" tab and "Add" the version listed above. You may need to visit the "download archive" shown in the Unity Hub "Add a Unity Version" dialog box in order to find the version you need.

![Unity_find_your_version.png](https://gatech.instructure.com/courses/202032/files/24382183/preview)

Choose at least the following modules:

-   Mac Build Support (select both IL2CPP and Mono variants unless only one option is present on your platform)
-   Windows Build Support (select both IL2CPP and Mono variants unless only one option is present on your platform)
-   Documentation
-   Depending on your platform, you may have the option to install Visual Studio or another IDE as part of the Unity install. It may be worth selecting.

**Code Editing IDE**

Visual Studio Community Edition is recommended for both Windows and Mac. But you might also want to use [JetBrains Rider (Links to an external site.)](https://www.jetbrains.com/rider/) or something else. 

Mac: [https://visualstudio.microsoft.com/vs/mac/unity/ (Links to an external site.)](https://visualstudio.microsoft.com/vs/mac/unity/)

Enable Visual Studio Integration (if not already): [https://docs.unity3d.com/Manual/VisualStudioIntegration.html (Links to an external site.)](https://docs.unity3d.com/Manual/VisualStudioIntegration.html)

Tools for Unity Visual Studio Extension (if not already installed in your VStudio): [https://docs.microsoft.com/en-us/visualstudio/gamedev/unity/get-started/visual-studio-tools-for-unity (Links to an external site.)](https://docs.microsoft.com/en-us/visualstudio/gamedev/unity/get-started/visual-studio-tools-for-unity)

-   IntelliSense code completion
-   Debugger
-   Whichever editor you use, getting code completion and debugging are well worth the effort!

Unity Testing
=============

After you have completed [Unity 3D Installation](https://gatech.instructure.com/courses/202032/pages/unity-3d-installation), you should test the engine. It is especially important to assess whether you can effectively run Unity well before course registration ends. If you have significant hardware issues that cannot be resolved, you should consider switching to a different class until you can update your hardware.

A good place to start is completing the first assignment, Milestone 0. In addition to editing and running the interactive game in the development environment, you should also try to build for both Windows and Mac. 

Another thing you can try is to open the starter project for Milestones 1 through 4. Be sure to open the provided scene (not the empty scene that Unity automatically creates). Test if you can both run interactively in the editor as well as build. Note that when you first open the starter project, expect to see many warnings about legacy import settings. You can ignore those.

Here is the project link:

[https://github.gatech.edu/IMTC/CS4455_M1_Support (Links to an external site.)](https://github.gatech.edu/IMTC/CS4455_M1_Support)

Make sure you open the demo scene in the Scenes folder. Unity creates an empty scene by default whenever first opening a project.

One other good test that sometimes doesn't crop up as a problem until the team project is the terrain engine. You might consider quickly generating a terrain in a new Unity project to test this.

**Troubleshooting**

If you run into problems running Unity 3D, refer to the following tips for resolving common problems. If you still have trouble then please post your issue on Piazza.

Editor Renderer

If you do have problems, the most likely cause is integrated graphics chipsets. If your computer does not have a discrete GPU then you might experience crashes or weird artifacts on an integrated graphics chipset such as those made by Intel. This is most common on Macbooks.

If you have a Mac that is crashing Unity, try switching to the Metal Renderer.

Project Settings->Player:Other Settings:Metal Editor Support

[https://docs.unity3d.com/Manual/Metal.html (Links to an external site.)](https://docs.unity3d.com/Manual/Metal.html)

If you have a Windows PC that is crashing Unity, try switching to a different DirectX renderer by changing the Project Settings->Player->Other Settings(disable Auto Graphics API for Windows) then picking the driver that works best.

If you can't even get the Unity Editor to open long enough to make graphics changes, you might be able to manually edit your project settings config file and find the line about metal renderer or you may have luck with the command line arguments to the editor to force different drivers:

[https://docs.unity3d.com/Manual/CommandLineArguments.html (Links to an external site.)](https://docs.unity3d.com/Manual/CommandLineArguments.html)

Update Graphics Drivers

Another problem may be old graphics drivers on Windows machines. Try upgrading your drivers using the recommended procedure for your hardware. This may involve using Windows Update, visiting your computer manufacturer website, or possibly the company the develops your 3D accelerator (e.g. NVidia, AMD, etc.).

Missing Assets

A rare problem is for an asset to not appear in your project, possibly after attempting to import it. Sometimes, selecting Assets->Reimport All can fix a problem. You can also try exiting Unity, making a copy of your project, and then deleting the /Library and /Temp folders of one of the copies and then opening it. This forces the project to be reimported and may also resolve issues with unwritable files.

Version Control with Unity
==========================

We recommend that you set up your project with git. You can just use a local git repo if you don't want to use [github.gatech.edu (Links to an external site.)](https://github.gatech.edu/), but there are obvious benefits of remote backup. Git isn't absolutely necessary, but it does help to manage your projects! Be advised that github limits max individual file size to 100mb.

Also, you might like using Unity Collaborate: [https://unity3d.com/unity/features/collaborate (Links to an external site.)](https://unity3d.com/unity/features/collaborate)

Collaborate is based on git (with the added benefit of large file support). It was in a free beta test for a while, but costs money now. It may be worth it to you and your group.

Refer to these links for setting up Unity to do version control with your projects. Be sure to make the project settings to expose your meta data, change to text mode, etc.

[http://docs.unity3d.com/Manual/ExternalVersionControlSystemSupport.html (Links to an external site.)](http://docs.unity3d.com/Manual/ExternalVersionControlSystemSupport.html)

The new project selector for github has a Unity project option, but here is the .gitignore config if you need to set it manually:

[https://github.com/github/gitignore/blob/master/Unity.gitignore (Links to an external site.)](https://github.com/github/gitignore/blob/master/Unity.gitignore)

### How to merge files!

Merging files in Unity is sometimes a pain, especially for scene files. You need to use the special merge tool below if you want to be able to merge scene files. There are other Unity files that have similar issues (also handled by the merge tool).

[http://docs.unity3d.com/Manual/SmartMerge.html (Links to an external site.)](http://docs.unity3d.com/Manual/SmartMerge.html)

### Avoiding Merge Issues

When working in a group, it's often worth avoiding merge issues altogether. This can largely be accomplished by never working on the same scene file as another person. If you need to change a shared scene, you can do a "save as" and add a text version number like "Level 1 v.0.1". Whatever you have added to the scene can often be made into a prefab. Then a designated owner of the "Level 1" scene can refer to "Level 1 v.0.1." and see where the new prefab(s) have been added. This person can either manually copy the prefabs into place or just copy "Level 1 v.0.1" on top of "Level 1". This depends on whether there are merges or not.

The other place to watch out for merges are in the project settings. It is best to designate someone in charge of project settings. This includes things like tags and layers. If you need a new tag or layer, just tell the designated person to add it and update the repo.

Assignment Weighting
====================

**Note: Occasionally assignments need to be modified or dropped due to time constraints, but we try to maintain the overall weighting as best we can. Also, Canvas assignment point values are always on a 100 point scale and don't reflect the weights below.**

Final letter grades are based on the standard scale (>=90% == A, >=80% && <90% == B, etc.)

| Type                  | Assignment                                              | Value                                                                             |
|-----------------------|---------------------------------------------------------|-----------------------------------------------------------------------------------|
| Quizzes               | (10% Total)                                             |                                                                                   |
|                       | Q1                                                      | 5%                                                                                |
|                       | Q2                                                      | 5%                                                                                |
| Individual Milestones | (45% Total)                                             |                                                                                   |
|                       | Warmup                                                  | 1%                                                                                |
|                       | Character Control - Animation-Based                     | 11%                                                                               |
|                       | Environment Interaction (Physics)                       | 11%                                                                               |
|                       | UI and Prefabs                                          | 11%                                                                               |
|                       | AI                                                      | 11%                                                                               |
| Team Project          | (45% Total)                                             |                                                                                   |
|                       | Pitch and Interaction Demo                              | 4%                                                                                |
|                       | Alpha Demo                                              | 8%                                                                                |
|                       | Playtesting and Analysis                                | 8%                                                                                |
|                       | Final Game (Presentation, Video, Code Submission, etc.) | 25%                                                                               |
|                       | Also, see: Team Issues and Impact on Assigned Grade     | Failure to participate can result in all team project credits lost for individual |


Game Engines: Introduction
==========================

This learning module is an introduction to Game Engines. In order to effectively design and create video games, it is important to understand the core concepts of game engines. This includes understanding some basics of human perception, concepts of interactive simulation, and interactive software engineering.

The full video for this multi-part lecture is:

[Game Engines (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Engines/1_v46y7wl7) (02:30 runtime)

The lecture notes can be downloaded here:

[GameEngines.pdf](https://gatech.instructure.com/courses/202032/files/24382113/download?wrap=1 "GameEngines.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382113/download?download_frd=1)

The module steps for Game Engines break the lecture up into parts that coincide with the course schedule.

Game Engines: Basic Game Engines, and Human Perception
======================================================

Watch: [Game Engines: Basic Game Engines, Human Perception, and Simulation Concepts (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Engines/1_v46y7wl7?st=0&ed=1139) (00:18:59 runtime)

The link starts with the lecture introduction (00:00:00) and ends before "Simulation Concepts" (00:18:59).

Game Engines: Simulation Concepts, and Side Quests: Breaking with Tradition
===========================================================================

Watch: [Game Engines: Simulation Concepts (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Engines/1_v46y7wl7?st=1139&ed=4609) (58:10 runtime)

The link starts with chapter "Simulation Concepts" (0:18:59) and ends before the start of "Synchronizing Real Time with Simulation" (1:16:49)

Game Engines: Synchronizing Real Time with Simulation
=====================================================

Watch: [Game Engines: Synchronizing Real Time with Simulation (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Engines/1_v46y7wl7?st=4609&ed=7174) (42:45 runtime)

The linked video starts with chapter "Synchronizing Real Time with Simulation" (1:16:49) and ends before the start of "Game Engines" (1:59:34).

Game Engines: The Modern Game Engine
====================================

Watch: [Game Engines: The Modern Game Engine (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Engines/1_v46y7wl7?st=7174)

The link includes a start time for chapter "Game Engines" (1:59:34) and ends with the conclusion of the video.

Animation: Introduction
=======================

This learning module expands on animation as a critical element of game engines for visual simulation of objects in motion. First, we explore the history of both passively viewed and interactive animation. Next, we look at the implementation of animation in early 2D video games. Lastly, we focus on animation techniques used in 3D games.

The full lecture set consists of the following videos: [Early Animation (Links to an external site.)](https://mediaspace.gatech.edu/media/Early+Animation/1_81k66btw) (47:14 runtime), [Interactive Animation in Video Games (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Animation+in+Video+Games/1_vldjkzqt) (02:23:04 runtime), and [Unity Interactive Animation (Links to an external site.)](https://mediaspace.gatech.edu/media/Unity+Interactive+Animation/1_35msp0bs) (01:41:27 runtime)

The lecture notes are available here: [Animation.pdf](https://gatech.instructure.com/courses/202032/files/24382023/download?wrap=1 "Animation.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382023/download?download_frd=1)

The module steps for Animation break the lecture up into parts that coincide with the course schedule.

Animation: Early Animation
==========================

This lecture explores the earliest examples of animation and shows the progression of animation technology, including some interactive examples predating computer-based implementations. Modern techniques in animation build off of the traditions developed in these early examples of animation.

Watch: [Early Animation (Links to an external site.)](https://mediaspace.gatech.edu/media/Early+Animation/1_81k66btw) (47:14 runtime)

Recommended:

(apologies for the biased gender roles in the workplace as presented in this historical piece)  [Making Of Disneys Snow White or How Disney Cartoons are Made](https://www.youtube.com/watch?v=OebUzEhSLBI)

Animation: 2D Animation in Video Games
======================================

This lecture explores early interactive computer-based animation focusing on predominantly 2D-based approaches such as sprite animation.

Watch: [Interactive Animation in Video Games (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Animation+in+Video+Games/1_vldjkzqt?ed=5246) (0:55:38 runtime)

The link above starts with the lecture introduction (00:00:00) and ends before "3D animation in Video Games" (0:55:38).

Optional: [Another World: Demonstration of Rotoscoped 2D Animation in a Game (Links to an external site.)](https://mediaspace.gatech.edu/media/Another+World/1_zbuu69f7) (08:03 runtime)

Animation: 3D Animation in Video Games
======================================

This lecture covers 3D animation techniques, which are still relied upon in modern video games.

Watch: [Interactive Animation in Video Games (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Animation+in+Video+Games/1_vldjkzqt?st=3338) (1:27:26 runtime)

The link starts with chapter "3D animation in Video Games" (0:55:38) and runs to completion.

Recommended:

[The Animation of Jak and Daxter - #1 - SQUASH and STRETCH](https://www.youtube.com/watch?v=BbP6Jsh8M6Y)

Animation: Interactive Animation in Unity
=========================================

This lecture demonstrates the animation system in Unity and will help with completing Milestone 1.

Watch: [Unity Interactive Animation (Links to an external site.)](https://mediaspace.gatech.edu/media/Unity+Interactive+Animation/1_35msp0bs) (1:41:27 runtime)

Physics: Introduction
=====================

This learning module presents the concept of a Physics Engine and describes the common features and limitations. Students will gain an understanding of how to utilize physics engines in game development.

The full lecture set consists of the following videos: [Video Game Physics Engines (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Physics+Engines/1_9c85jth1) (01:56:12 runtime) and [Unity Physics (Links to an external site.)](https://mediaspace.gatech.edu/media/Unity+Physics/1_n9ic97pr) (01:21:13 runtime)

The lecture notes are available here: [Physics.pdf](https://gatech.instructure.com/courses/202032/files/24382189/download?wrap=1 "Physics.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382189/download?download_frd=1)

The module steps for Physics break the lecture up into parts that coincide with the course schedule.

Physics: Basic Concepts and Collision Detection
===============================================

This lecture introduces the basic concept of a physics engine and explores methods for collision detection in frame based simulation.

Watch: [Video Game Physics Engines (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Physics+Engines/1_9c85jth1?ed=3525) (57:27 runtime)

This video starts at the introduction and ends before chapter collision dynamics (57:27)

Physics: Collision Dynamics, Constraints, and Interaction
=========================================================

This lecture presents a high level discussion of the implementation of collision dynamics in a physics engine as well as the use of constraints to restrict motion (such as joints). Also, methods for interaction with the physics engine such as by programmatically applying forces are presented.

Watch: [Video Game Physics Engines (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Physics+Engines/1_9c85jth1?st=3525) (57:27 runtime)

This video starts with chapter Collision Dynamics (58:45) and runs to completion.

Physics: Implementing Physics in Unity
======================================

This video demonstrates use of the physics engine in Unity, including covering many aspects of Milestone 2.

Watch: [Unity Physics (Links to an external site.)](https://mediaspace.gatech.edu/media/Unity+Physics/1_n9ic97pr) (1:21:13 runtime)

Case Study: Trespasser
======================

In this learning module, the game Trespasser is explored for its contributions to video game technology such as physics simulation but also its failure to provide a gameplay experience with broad appeal for its target audience.

Watch: [Trespasser Case Study (Links to an external site.)](https://mediaspace.gatech.edu/media/Trespasser+Case+Study/1_0pnh7atf) (59:55 runtime)

Lecture Notes: [Trespasser.pdf](https://gatech.instructure.com/courses/202032/files/24382107/download?wrap=1 "Trespasser.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382107/download?download_frd=1)

Recommended: 

If you don't mind the crass language, you might enjoy Angry Video Game Nerd's evaluation of Trespasser. There are some interesting debug visualizations and even a brief interview with Seamus Blackley.

[Angry Video Game Nerd (AVGN) - Jurassic Park: Trespasser](https://www.youtube.com/watch?v=15pi8vrUx9c)

Game Feel
=========

In this learning module, Steve Swink's concept of Game Feel is presented. The enjoyable experiences that can arise from gameplay are also detailed. Lastly, example games are discussed.

Watch: [Game Feel (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Feel/1_657fm809) (runtime 1:09:20)

Lecture Notes: [GameFeel.pdf](https://gatech.instructure.com/courses/202032/files/24382141/download?wrap=1 "GameFeel.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)](https://gatech.instructure.com/courses/202032/files/24382141/download?download_frd=1)

Formal Elements
===============

In this learning module, the concept of formal elements is presented. Games can be described by their formal elements in a way that allows for efficient analysis and design. The game Katamari Damacy is used as an example. 

Watch: [Formal Elements (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Formal+Elements/1_1v9zslxf) (36:07 runtime)

Recommended: [Katamari Damacy Gameplay Example (Links to an external site.)](https://mediaspace.gatech.edu/media/Katamari+Damacy/1_dmwhps5u) (34:49 runtime)

Lecture Notes: [FormalElementsOfGames.pdf](https://gatech.instructure.com/courses/202032/files/24382087/download)

AI: Intro
=========

This learning module presents artificial intelligence concepts and algorithms suitable for implementing real-time agents in video games. Students will learn methods for implementing reactive agents with real-time steering behaviors, path planning, and basic decision making.

The full lecture set consists of the following videos: [Steering Behaviors (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+AI+Steering+Behaviors/1_7xbf6m57) (01:39:24 runtime), [Grid Lattice (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Grid+Lattice/1_l73ik4g8) (40:11 runtime), [Path Search (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Path+Search/1_ljllisii) (23:30 runtime), [Path Networks and NavMeshes (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Path+Networks+and+NavMeshes/1_504gjuy0) (47:09 runtime), [Decision Making (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Game+AI+-+Decision+Making/1_3jct6i8o) (01:14:48 runtime)

Also you might optionally watch a demonstration for Milestone 4 help: [Milestone 4 NavMesh Demo (Links to an external site.)](https://mediaspace.gatech.edu/media/VGD+Milestone+4+Demo/1_qo7m1rcc) (20:25 runtime)

The lecture notes are available here: [SteeringBehavior.pdf](https://gatech.instructure.com/courses/202032/files/24382203/download?wrap=1 "SteeringBehavior.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382203/download?download_frd=1), [PathPlanning_Intro_and_Grid.pdf](https://gatech.instructure.com/courses/202032/files/24382205/download?wrap=1 "PathPlanning_Intro_and_Grid.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382205/download?download_frd=1), [PathPlanning_Dijkstra_AStar.pdf](https://gatech.instructure.com/courses/202032/files/24382069/download?wrap=1 "PathPlanning_Dijkstra_AStar.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382069/download?download_frd=1), [PathPlanning_PathNetworks_Navmeshes.pdf](https://gatech.instructure.com/courses/202032/files/24382137/download?wrap=1 "PathPlanning_PathNetworks_Navmeshes.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382137/download?download_frd=1), [DecisionMaking.pdf](https://gatech.instructure.com/courses/202032/files/24382197/download?wrap=1 "DecisionMaking.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382197/download?download_frd=1)

The module steps for AI break the lecture up into parts that coincide with the course schedule.

AI: Steering Behaviors - Part I
===============================

The concept of steering behaviors for moment to moment agent movement is presented. 

Watch: [AI Steering Behaviors (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+AI+Steering+Behaviors/1_7xbf6m57?ed=3425) (57:05 runtime)

The link starts with the lecture introduction (00:00:00) and ends before "Root Motion Steering" (00:57:05)

AI: Steering Behaviors - Part II
================================

In this lecture, steering behaviors are expanded upon to consider agents controlled by a root motion based animation system. Additionally, ballistic projectile aiming and perceptual models are considered.

Watch: [AI Steering Behaviors (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+AI+Steering+Behaviors/1_7xbf6m57?st=3425) (42:19 runtime)

The link starts with chapter "Root Motion Steering" (00:57:05) and ends at the conclusion of the video

AI: Path Planning - Part I - Introduction and Grid Lattice
==========================================================

In this lecture, the concept of path planning via a discretized space is presented. The grid lattice is considered as a basic discretized space.

Watch: [Path Planning Intro and Grid Lattice (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Grid+Lattice/1_l73ik4g8) (40:11 runtime)

AI: Path Planning - Part II - Path Search with AStar
====================================================

This lecture considers graph search algorithms most suited to path planning. In particular, the A* (a-star) algorithm is demonstrated as being especially effective for game AI.

Watch: [Path Search and A* (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Path+Search/1_ljllisii) (23:30 runtime)

AI: Path Planning - Part III - Path Networks and NavMeshes
==========================================================

Video game environments can often be more effectively discretized with structures other than the grid lattice. The path network and navMesh are considered.

Watch: [Path Networks and NavMeshes (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Path+Networks+and+NavMeshes/1_504gjuy0) (47:09 runtime)

AI: Decision Making
===================

In conclusion of the exploration of basic AI techniques for video games, reactive decision making techniques are considered. This lecture looks at finite state machines, behavior trees, and other approaches to providing high level control of an agent.

Watch: [Decision Making (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Game+AI+-+Decision+Making/1_3jct6i8o) (01:14:48 runtime)

AI M4 NavMesh Demo
==================

Optional demonstration for Milestone 4 help: [Milestone 4 NavMesh Demo (Links to an external site.)](https://mediaspace.gatech.edu/media/VGD+Milestone+4+Demo/1_qo7m1rcc) (20:25 runtime)


Game Object Dependencies and Communication
==========================================

It can be a challenge to effectively support communication between objects and subsystems within a game/simulation. The following lecture discusses a variety of software engineering strategies to deal with this issue.

Watch: [Game Object Dependencies and Communication (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Object+Dependencies+and+Communication/1_qv2vcg5u) (01:30:22 runtime)

Lecture Notes: [GameObjectDependencies.pdf](https://gatech.instructure.com/courses/202032/files/24382135/download?wrap=1 "GameObjectDependencies.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)](https://gatech.instructure.com/courses/202032/files/24382135/download?download_frd=1)

Prototyping: Intro
==================

This learning module discusses the utility of prototyping game concepts to aid in game design. Two case studies further explore the benefits of prototyping.

The full lecture set consists of the following videos: [Prototyping (Links to an external site.)](https://mediaspace.gatech.edu/media/Prototyping/1_xynygwo2) (45:02 runtime), [Rapid Prototypng (Links to an external site.)](https://mediaspace.gatech.edu/media/Rapid+Prototyping/1_of4xvmt6) (29:18 runtime), [Tilt to Live (Links to an external site.)](https://mediaspace.gatech.edu/media/Prototyping+-+Tilt+To+Live/1_60tzw04x) (13:55 runtime)

The lecture notes are available here: [Prototyping.pdf](https://gatech.instructure.com/courses/202032/files/24382199/download?wrap=1 "Prototyping.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382199/download?download_frd=1), [RapidPrototyping.pdf](https://gatech.instructure.com/courses/202032/files/24382095/download?wrap=1 "RapidPrototyping.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382095/download?download_frd=1), and [OneManLeft-TiltToLive.pdf](https://gatech.instructure.com/courses/202032/files/24382193/download?wrap=1 "OneManLeft-TiltToLive.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382193/download?download_frd=1)

The module steps break the lecture up into parts that coincide with the course schedule.

Prototyping: Basics
===================

This lecture introduces concepts in prototyping gameplay. 

Watch: [Prototyping (Links to an external site.)](https://mediaspace.gatech.edu/media/Prototyping/1_xynygwo2) (45:02 runtime)

Recommended: 

[Legend of Zelda - Breath of the Wild - GDC 2017 Talk](https://www.youtube.com/watch?v=QyMsF31NdNc)

Prototyping: Case Study - Rapid Prototyping
===========================================

A case study of the Experimental Gameplay course at Carnegie Mellon's Entertainment Technology Center is presented. Students in the class worked on extremely short development cycles to prototype a variety of gameplay concepts.

Watch: [Rapid Prototyping (Links to an external site.)](https://mediaspace.gatech.edu/media/Rapid+Prototyping/1_of4xvmt6) (29:18 runtime)

Prototyping: Case Study - Tilt to Live
======================================

GT alumni Alex Okafor successfully used prototyping techniques learned in the Video Game Design course to develop the popular handheld game, Tilt to Live. This lecture provides a brief case study of Alex's work.

Watch: [A Case Study of Tilt to Live (Links to an external site.)](https://mediaspace.gatech.edu/media/Prototyping+-+Tilt+To+Live/1_60tzw04x) (13:55 runtime)

Case Study: Valve's Cabal Design Process
========================================

This learning module presents a case study of Valve's Cabal Design Process. The Cabal is a flat organizational hierarchy that embraces a design philosophy that focuses on user experience and is validated through extensive playtesting.

Watch: [Valve's Cabal Design Process (Links to an external site.)](https://mediaspace.gatech.edu/media/Valve%27s+Cabal+Design+Process/1_6sy25y08) (57:53 runtime) and [Half-Life 2 Episode I - In Game Commentary Highlights (Links to an external site.)](https://mediaspace.gatech.edu/media/Half-Life+2+Episode+I+-+In+Game+Commentary+Highlights/1_5h8zqwm1) (14:47 runtime)

Lecture Notes: [TheCabal.pdf](https://gatech.instructure.com/courses/202032/files/24382139/download?wrap=1 "TheCabal.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)](https://gatech.instructure.com/courses/202032/files/24382139/download?download_frd=1)

Playtesting
===========

This learning module explores methods for playtesting of video games. This includes methods for data collection as well as analysis.

Watch: [Playtesting (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Playtesting/1_wef29ttx) (01:16:38 runtime)

Lecture Notes: [Playtesting.pdf](https://gatech.instructure.com/courses/202032/files/24382201/download?wrap=1 "Playtesting.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)](https://gatech.instructure.com/courses/202032/files/24382201/download?download_frd=1)

Audio: Intro
============

This learning module covers concepts in digital audio presentation, audio design as applied to video games, and practical audio editing.

The full lecture set consists of the following videos: [Digital Audio (Links to an external site.)](https://mediaspace.gatech.edu/media/Digital+Audio/1_hxg3i29o) (01:26:04 runtime), [Audio for Games (Links to an external site.)](https://mediaspace.gatech.edu/media/Audio+for+Games/1_6hr42dct) (01:37:43 runtime), [Editing with Audacity (Links to an external site.)](https://mediaspace.gatech.edu/media/Audacity+Audio+Editing/0_v48w7mjx) (26:59 runtime)

The lecture notes are available here: [Digital Audio.pdf](https://gatech.instructure.com/courses/202032/files/24382171/download?wrap=1 "Digital Audio.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382171/download?download_frd=1), [Audio for Games.pdf](https://gatech.instructure.com/courses/202032/files/24382191/download?wrap=1 "Audio for Games.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382191/download?download_frd=1)

The module steps break the lecture up into parts that coincide with the course schedule.

Audio: Digital Audio Concepts
=============================

This lecture presents the fundamentals of digital audio.

Watch: [Digital Audio (Links to an external site.)](https://mediaspace.gatech.edu/media/Digital+Audio/1_hxg3i29o?ed=2681) (41:21 runtime)

The link above starts with the lecture introduction (00:00:00) and ends before chapter "Human Hearing" (41:23).

Audio: Psychoacoustics
======================

In this lecture the impact of psychoacoustics on digital audio is considered. Additionally,  an introduction to the parts of a game soundtrack is presented.

Watch: [Digital Audio: Psychoacoustics and Game Soundtrack (Links to an external site.)](https://mediaspace.gatech.edu/media/Digital+Audio/1_hxg3i29o?st=2681) (44:41 runtime)

The link above starts with the chapter "Human Hearing" (41:23 [▲](https://gatech.instructure.com/courses/202032/pages/uh-oh)) and runs to completion

Audio: 3D Audio for Games and Notable Games
===========================================

This lecture examines common API features for realtime 3D audio rendering. Additionally, games notable for their sound design are presented.

Watch: [3D Audio for Games and Notable Games (Links to an external site.)](https://mediaspace.gatech.edu/media/Audio+for+Games/1_6hr42dct?ed=3915) (runtime 01:05:15)

The link above starts with the lecture introduction (00:00:00) and ends before chapter "Music Theory Intro: Gambling Games and Arcade..." (01:05:15).

Audio: Music Theory for Games and Audio Editing Concepts
========================================================

In this lecture the application of music theory to game audio design is considered. Also, common audio editing techniques are described.

Watch: [Music Theory for Games and Audio Editing Concepts (Links to an external site.)](https://mediaspace.gatech.edu/media/Audio+for+Games/1_6hr42dct?st=3915) (00:32:28 runtime)

The link above starts with "3D animation in Video Games" (0:55:38) and runs to completion.

Audio: Editing with Audacity
============================

This lecture is a demonstration of some basic Audacity features that students might find useful for creating custom sound effects in their games.

Watch: [Audio Editing with Audacity (Links to an external site.)](https://mediaspace.gatech.edu/media/Audacity+Audio+Editing/0_v48w7mjx) (26:59 runtime)

[Previous](https://gatech.instructure.com/courses/202032/modules/items/1938076)[Next](https://gatech.instructure.com/courses/202032/modules/items/1938080) Done

[](abp:subscribe?location=https://www.joinhoney.com/whitelist/honey-smart-shopping.txt&title=Honey-Smart-Shopping)

Interesting Choices: Intro
==========================

This learning module explores the design of player choice opportunities in games. General categories of choices are presented that can help guide game designers in classifying choice opportunities in their own games. This strategy can aid a game designer in refining gameplay to ensure that all choices are interesting and enjoyable for the player.

Watch: [Interesting Choices (Links to an external site.)](https://mediaspace.gatech.edu/media/Interesting+Choices/1_i6ipdysj) (1:30:59 runtime)

Lecture Notes: [InterestingChoices.pdf](https://gatech.instructure.com/courses/202032/files/24382097/download?wrap=1 "InterestingChoices.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382097/download?download_frd=1)

The module steps break the lecture up into parts that coincide with the course schedule.

Interesting Choices and Dilemmas
================================

The concept of interesting choices are presented including desirable features and choice types that should be avoided. Further, dilemmas are presented as an ideal choice type.

Watch: [Interesting Choices and Dilemmas (Links to an external site.)](https://mediaspace.gatech.edu/media/Interesting+Choices/1_i6ipdysj) [⛵](https://gatech.instructure.com/courses/202032/pages/skipping-stones-to-lonely-homes)(50:49 runtime)

The link above starts with the lecture introduction (00:00:00) and ends before chapter "Rewards and Punishment" (50:49).

Interesting Choices - Reward and Punishment and Fun Killers
===========================================================

Interesting choices are further explored in the ways that player choice can be rewarded or punished. In closing, "fun killers" are assessed for the negative impacts that some choices can have on gameplay.

Watch: [Interesting Choices - Reward and Punishment and Fun Killers (Links to an external site.)](https://mediaspace.gatech.edu/media/Interesting+Choices/1_i6ipdysj?st=3049) (40:10 runtime)

The link above starts with chapter "Rewards and Punishment" (50:49) and runs to completion.

Interactive Narrative: Intro
============================

This learning module presents the challenge of making a narrative an interactive part of gameplay. Students will learn how video game interactivity is at odds with conventional storytelling. Established strategies for introducing interactivity are discussed such as branching narrative. Lastly, research efforts working towards more interactive narratives are introduced.

The full lecture set consists of the following videos: [Interactive Narrative - Part I (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Narrative+-+Part+I/1_e7zsn7es) (01:10:10 runtime), [Interactive Narrative - Part II (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Narrative+-+Part+II/1_sat6mlt4) (50:00 runtime), [Interactive Narrative - Part III (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Narrative+-+Part+III/1_31g9de02) (54:20 runtime)

The lecture notes are available here: [Narrative.pdf](https://gatech.instructure.com/courses/202032/files/24382129/download?wrap=1 "Narrative.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382129/download?download_frd=1)

The module steps break the lecture up into parts that coincide with the course schedule.

Interactive Narrative: Part I - Storytelling and Branching Narrative
====================================================================

This lecture introduces the fundamentals of conventional storytelling, then presents the challenges of integrating storytelling with interactive video games. Strategies such as branching narrative, interactive narrator, etc., are presented. 

Watch: [Interactive Narrative - Part I (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Narrative+-+Part+I/1_e7zsn7es) (01:10:10 runtime)

Interactive Narrative: Part II - Machinima
==========================================

In this lecture, creative approaches to integrating conventional storytelling into video games are concluded. This includes techniques such as parallel story threads (e.g. "groundhog day" scenario). Next, the important role of Machinima as a storytelling mechanism is presented.

Watch: [Interactive Narrative: Part II (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Narrative+-+Part+II/1_sat6mlt4) (runtime 50:00)

Recommended: [Demo Scene Example: Future Crew - Second Reality (Links to an external site.)](https://mediaspace.gatech.edu/media/Demo+Scene+Example+Future+Crew+-+Second+Reality/1_4i66gpjk) (09:13)

Interactive Narrative: Part III - Advances in Interactive Narrative
===================================================================

This lecture concludes discussion of interactive narrative with an exploration of the technology necessary to expand the choices that a game player can make that will affect the direction of a narrative. In particular, the interactive narrative experience, Facade, is presented.

Watch: [Interactive Narrative - Part III (Links to an external site.)](https://mediaspace.gatech.edu/media/Interactive+Narrative+-+Part+III/1_31g9de02) (54:20 runtime)

Future of Games: Intro
======================

This learning module explores developing gaming trends, cultural influences on games, and explores what the future may hold for gaming.

The full lecture set consists of: [Future of Games - Part I (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+I/1_f3hcl7qe) (55:42 runtime), [Future of Video Games - Part II (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+II/1_uhm09il4) (59:32 runtime), [Future of Video Games - Part III (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+III/1_u9arp5ev) (01:24:07 runtime)

The lecture notes are available here: [FutureGames.pdf](https://gatech.instructure.com/courses/202032/files/24382029/download?wrap=1 "FutureGames.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382029/download?download_frd=1)

The module steps break the lecture up into parts that coincide with the course schedule.

Future of Games: Developing Gaming Trends - VR/AR
=================================================

This lecture focuses on the developing trends of VR/AR gaming and Free-to-play/Pay-to-win games.

Watch: [Future of Video Games - Part I (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+I/1_f3hcl7qe) (55:42 runtime)

Future of Games: Developing Gaming Trends - ARGs, Education, Gamification, etc.
===============================================================================

This lecture expands on gaming trends such as ARGs, Serious Games (Education, Fitness/Health, Social Messages, [▲](https://gatech.instructure.com/courses/202032/pages/triforce) Gamification), and Transportation influenced games.

Watch: [Future of Video Games - Part II (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+II/1_uhm09il4) (59:32 runtime)

Future of Games: More Trends and Gaming Zeitgeist
=================================================

This lecture further explores gaming trends such as eSports, In-Progress Games, and Mash-ups. Additionally, cultural influences on games and vice versa are considered.

Watch: [Future of Video Games - Part III - A (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+III/1_u9arp5ev?ed=2414) (40:14 runtime)

The above link starts with the beginning of the lecture and ends just before chapter "Far Future of Games" (40:14).

Future of Games: Far Future
===========================

This lecture takes a look at the far future of gaming, starting with plausible scenarios but then expanding to some topics that are clearly science fiction.

Watch: [Future of Video Games - Part III - B (Links to an external site.)](https://mediaspace.gatech.edu/media/Future+of+Video+Games+-+Part+III/1_u9arp5ev?st=2414) (43:53 runtime)

Team Activities: Intro
======================

This is an optional module that won't be covered on the quizzes. However, you may find this useful for working on your team project.

Your team will be working on brainstorming gameplay ideas, prototyping gameplay, development, and playtesting. To aid in these tasks, some supplementary materials are provided.

Video lectures in this module: [Video Game Design Projects Demo Reel (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+Projects+Demo+Reel/1_67znhu88) (05:38:50 runtime) and also see the dedicated page in the module for more recent semesters, [Brainstorming (Links to an external site.)](https://mediaspace.gatech.edu/media/Brainstorming/1_e17soaoz) (25:28 runtime), [Fun (Links to an external site.)](https://mediaspace.gatech.edu/media/Fun/1_jfoobj10) (33:46 runtime)

Lecture Notes: [Brainstorming.pdf](https://gatech.instructure.com/courses/202032/files/24382043/download?wrap=1 "Brainstorming.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg) download](https://gatech.instructure.com/courses/202032/files/24382043/download?download_frd=1), [Fun.pdf](https://gatech.instructure.com/courses/202032/files/24382177/download?wrap=1 "Fun.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382177/download?download_frd=1)

Document: [DesignDocuments.pdf](https://gatech.instructure.com/courses/202032/files/24382187/download?wrap=1 "DesignDocuments.pdf")[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382187/download?download_frd=1)

You should also consider checking out the Formal Elements and Prototyping Modules ahead of lecture schedule to help with brainstorming and prototyping activities your team may choose to pursue. Playtesting is also a standalone module but will be covered in the lecture schedule well before your playtesting assignment.

Team Activities: Previous Projects
==================================

If you are interested in the types of games teams have previously built, you can check out

[2020 Fall OMSCS CS6457 (Links to an external site.)](https://mediaspace.gatech.edu/media/CS6457+Video+Game+Design+Fall+2020+OMSCS+-+Game+Trailers/1_c8p3n194) (40:11 runtime)

[2020 Fall On-Campus CS4455/CS6457 (Links to an external site.)](https://mediaspace.gatech.edu/media/CS4455+CS6457+Video+Game+Design+Fall+2020+-+Game+Trailers/1_1qxrd67r) (34:15 runtime)

Also, there is mega-demo-reel from previous on-campus semesters. It spans several years of Video Game Design course offerings. The video is roughly in chronological order. Different years used different game engines and had different requirements. Given the length, you will probably want to skip around.

[Video Game Design Projects Demo Reel (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+Projects+Demo+Reel/1_67znhu88) (05:38:50 runtime!!!)

Team Activities: Brainstorming
==============================

Your team may benefit from some structure to your brainstorming meetings as you try to come up with cool ideas for your game. The following lecture describes mindset as well as some structured activities that your group can participate in for brainstorming. Based on *Game Design Workshop Chapter 6 Conceptualization*.

Watch: [Brainstorming (Links to an external site.)](https://mediaspace.gatech.edu/media/Brainstorming/1_e17soaoz) (25:38 runtime)

Team Activities: Fun
====================

What makes a game fun? With help from the *Game Design Workshop (Chapter 11 Fun and Accessibility),* we break down gameplay experiences into different general categories of fun. With this understanding, we can guide our game designs and ask the right questions during a play test.

Watch: [Fun (Links to an external site.)](https://mediaspace.gatech.edu/media/Fun/1_jfoobj10) (33:46 runtime)

Team Activities: Design Document
================================

A Design Document provides a way for a development team to organize their ideas and ensure that everyone is on the same page in terms of vision and development tasks. The *Game Design Workshop* covers Design Documents and other ways to communicate your design in *Chapter 14 Communicating Your Designs*.

A brief summary is provided here: [DesignDocuments.pdf](https://gatech.instructure.com/courses/202032/files/24382187/download?wrap=1)[ ![](https://gatech.instructure.com/images/svg-icons/svg_icon_download.svg)download](https://gatech.instructure.com/courses/202032/files/24382187/download?download_frd=1)

Your team should consider developing your own internal Design Document. A shared online document or Wiki can be a great solution. There are lots of options such as Office 365, Google Docs, Evernote, notion.so, etc.

Supplementary Topics: Intro
===========================

This is an optional module and won't be covered on the quizzes. Supplementary Topics may be added over the course of the semester.

The module currently includes the following:

Video Lectures: [Video Game Debugging (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Debugging/1_q9veo59o) (38:55 runtime)

Supplementary Topics: Video Game Debugging
==========================================

In this lecture, a variety of techniques are presented for debugging video games or other interactive simulation. 

There are lots of ways to debug computer programs in general. Many of those some approaches can be useful with video games. However, video games can pose their own challenges given the incremental frame-based nature of simulation algorithms. Data changes rapidly, there can be an overwhelming amount of debug information, efforts to debug can lead to considerable slow-down of the simulation, etc.

This lecture demonstrates approaches specific to Unity, but should generally apply to other game engines as well.

Watch: [Video Game Debugging (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Debugging/1_q9veo59o) (38:55 runtime)

Supplementary Topics: Unity Value Types
=======================================

This video discusses by-reference and by-value language features in C# and Unity API conventions that occasionally cause students confusion (such as classes vs. structs and no-alloc get methods).

Watch: [Unity Value Types (Links to an external site.)](https://mediaspace.gatech.edu/media/Unity+Value+Types/1_hbsvrdss) (23:48 runtime)

Supplementary Topics: Divide by Zero
====================================

Every programmer learns very quickly about divide by zero errors. But in video game development you might find catching divide by zero errors more difficult than you are used to. One of the biggest contributors to this is the use of linear algebra libraries. These libraries can be very useful but can hide important details that may lead to errors. Additionally, the nature of linear algebra operations (like matrix multiplication) means that a single bad float value can propagate very quickly through your transforms and other data.

For instance, the normalization of a vector involves dividing the vector by its magnitude. If the magnitude is zero, then you have a divide by zero situation even though you are not directly using the division operator. Instead you need to know to be cautious any time you use Vector3.Normalize(). Note that in Unity's case the API actually deals with the divide by zero, but the resultant vector will be zero. Unity is actually very good overall about diminishing the effects of divide by zeros as compared with other game engines and graphics APIs!

If you are testing some new video game feature you are implementing and observe a game object that suddenly disappears, one of the first things you should suspect is that a divide by zero was introduced in your logic.

An easy way to test for divide by zeros or other numerical problems (like square root of negative numbers) is by using float.IsNan(), float.IsInfinity(), float.IsNegativeInfinity(), float.IsPositiveInfinity(). You can perhaps also combine these tests in an Assert() statement.

One last thing. Even if you avoid a divide by zero, you may have a situation where you are approaching a zero denominator. This can cause some strange effects and is generally due to floating point values having limited resolution. For instance, if you are normalizing very small vector you might find that the direction jumps around a lot each frame you calculate or the user can never quite aim where they want. In this case, you might want to test vector lengths against an epsilon value.

Supplementary Topics: Adobe Fuse and Mixamo
Adobe Fuse is a simple editor for creating custom human 3D mesh models. It can also upload the models you create to Adobe Mixamo web app where the models will be auto-rigged for skeletal animation. Additionally, there is a library of animations that can be retargeted to your new model. The rigged model and animations can be exported to FBX format and imported into Unity. The models and animations are appropriate for player-controlled interactive characters or AI agents.

 

Watch: Adobe Fuse and Mixamo (Links to an external site.) (34:20 runtime)

 

The Milestone 2 pdf covering Interactive Animation has a Tips section with additional information about using Fuse/Mixamo. The text is also provide here:

Adobe’s Mixamo:

As of the end of 2018, exporting from Mixamo as regular FBX works slightly better than FBX-for- Unity, but you can get either to work.

I recommend you first make an assets folder for your new model so that you can see all the related import files for that specific model (e.g. make a folder “some_dude” that is empty).

One you add FBX to Unity Assets in the new folder from above, in Import Settings set Rig to Humanoid and Materials to “Use Exeternal Materials (Legacy)”. Then Apply. With a regular FBX you will probably get an error about incorrect normal map texture naming, but you can click a button to automatically fix it.

The weird bit now is that sometimes the import process doesn’t always completely run. In your assets you want an “Import Settings” object with the FBX base name, a “Materials” folder and another folder with the actual texture files (similar name as FBX model). You might try hitting play, adding/deleting model to your scene, hitting play some more, etc. Eventually you should get the full import to run and see the above mentioned assets. Just keep trying until you have all three. But you might get lucky and everything works first try.

If you are using the regular Mixamo FBX you will now need to go change the materials to be opaque so the model doesn’t look bizarre. With FBX for Unity you will need to do the same thing, but also you will need to manually assign each texture to the materials for Albedo and Normal map. For either case, I think Gloss textures can be placed in Metallic category but you will need to manually adjust Smoothness.

If you have freaky eye lashes or other parts that need transparency then you need to do the trick mentioned below.

More Mixamo:

Adobe Fuse may work better with the Mixamo server-side auto-rigging if you set your new models leg stance apart. Try doing this if the wrong part of the leg and/or clothing follows the wrong leg bone.

When using Fuse on OSX, you might have trouble adjusting your character’s physical properties. If nothing seems to work, check Fuse -> Preferences and under “App Options” set Maximum Adjustment Shape Value to 100.(https://forums.adobe.com/thread/2200004 (Links to an external site.))

Export your character model as FBX or FBX-for-Unity (see discussion above). It should come with a TPose “animation” that doesn’t actually animate.

When you add the model to your Unity assets, immediately change the rig to Humanoid and the avatar definition to “Create from this Model”

If your character looks weirdly inside out or partially transparent, you will need to change the character materials from transparent to opaque. If your character has eye lashes, you can make them look better if you duplicate the body material and make it transparent and then assign to the eyelash mesh. This can work for other geometry that needs transparency as well. See:

Mixamo Transparency Problem (Links to an external site.)
“This [problem] is actually a transparency issue with the way that Unity handles opacity. We recommend duplicating the body material, naming it 'eyelashes'. Set the body material to have no transparency. Set the eyelashes material to use transparency. Then just assign the new transparent material to the eyelashes alone and leave the non-transparent material on the body. You might need to check that transparency is off for the other textures as well”

Export each of your Mixamo animations as FBX for Unity.

When you add the animations to Unity assets, immediately change the rig to Humanoid

and the avatar definition to “Create from Other Avatar”. Drag the avatar from the

original T Pose model to the “Source” avatar field.

For all animations that are intended to be blended for on-foot locomotion (e.g.

walking, running), set the “Loop Time”==true. You will also probably want to set “Root Transform Position (Y)” to “Bake into Pose”==true. This will allow natural falling behavior. Also, see “Falling” section below.

For straight ahead locomotion you can set “Root Transform Rotation” “Bake into Pose”==true which can sometimes smooth out the chase camera from rocking back and forth.

You can usually use humanoid animations from another source with a Mixamo model (or any other rigged humanoid model). However, you typically don’t want to try to change the avatar on the animations themselves (because the bone names likely won’t match). Instead, just try adding the animations to your mecanim animation controller. This will often work with decent results if the models aren’t too different in dimensions. You can also just assign an existing AnimatorController to your new Mixamo character’s Animator. Use the Mixamo character’s avatar under the same Animator settings. This approach will usually give decent results as well.

You will find that Mixamo animations are often annoyingly all named “Mixamo.com” within the exported FBX file. You can change the name under the Animations tab of the Animation Inspector next to an icon that looks like a play button. This will make setting up blendtrees less painful as you will be able to identify each animation clip by name.

Supplementary Topics: AI - Object Oriented FSM - Prison Dodgeball
=================================================================

If you are interested in using an Object Oriented approach to implementing a Finite State Machine (FSM) then you may consider checking out the following project:

[https://github.gatech.edu/IMTC/GameAIPrisonDodgeBall (Links to an external site.)](https://github.gatech.edu/IMTC/GameAIPrisonDodgeBall)

It is the homework project for my Game AI course where students implement agents that play Prison Dodgeball.

It includes an FSM implementation with features such as:

-   Object Oriented Design
-   Global (wildcard) state transitions
-   Parameterized state transitions
-   Deferred state transitions
-   Optional immediate state updates on transition
-   Demonstration of agent coordination 

Here is a video with a demonstration of the Prison Dodgeball project along with a brief walkthrough of some of the code features:

Watch: [Prison Dodgeball (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Object+Oriented+FSM-+Prison+Dodgeball/1_imtjht87) (duration 28:58)

Supplementary Topics: Volume Partitioning
=========================================

Volume (or Space) Partitioning is an important topic for 3D video games. It's especially important for those games with large worlds. It can be quite a challenge to create a massive game world that also maintains interactive frame rates. Volume Partitioning allows a game designer to break up a game level into small parts that can be individually identified for rendering in an efficient manner. 

Historical context is discussed as well as a look at modern approaches, including application in the Unity game engine.

Watch: [Volume Partitioning (Links to an external site.)](https://mediaspace.gatech.edu/media/Video+Game+Design+-+Volume+Partitioning/1_oxn1ij2l) (01:08:43 runtime)

Supplementary Topics: Game Industry Round Table
===============================================

The following round table offers students the opportunity to learn about the game industry from professional game developers. The round table consisted of the following panelists:

-   Scott Brown - President & CEO, 6th Dimension, Inc.
-   Chris Dannemiller - OMSCS alumni, Principal Engineer at NVIDIA
-   Dion Gizas - OMSCS Student, Senior Software Engineer at MCR Federal (Tellus Studio), Co-Founder Bytewise Studios
-   Lisa Walkosz-Migliacio - OMSCS Student and TA, Game Designer and Developer

Watch: [Game Industry Round Table (Links to an external site.)](https://mediaspace.gatech.edu/media/Game+Industry+Round+Table/1_0whiqp8n) (01:17:54 duration)









