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

Schedule
========

### Video Game Design Schedule

**SUBJECT TO CHANGE**

This weekly calendar assumes weeks start on Monday and end on Sunday.

The due times are generally 11:59 PM [Anywhere on Earth Time (Links to an external site.)](https://www.timeanddate.com/time/zones/aoe) (AoE), but be sure to confirm the due date/time for each assignment in Canvas!

| **Week #** | **Week of** | **Lecture/Module** | **Deliverables** | **Deliverable Due Dates** |
| 1 | 08/23 |

Welcome to Video Game Design, Unity Installation and Testing, Game Engines 1-4

 | Milestone 0 | M0: 08/29 11:59 PM  |
| 2 | 08/30 | Game Engines 5, Animation 1-3, and begin 4 (3d anim) |  |  |
| 3 | 09/06 |

**09/06 - Labor Day**

Animation 4-5

 |

Milestone 1,

Team Formation

 |

Team Formation: 09/08 11:59 PM

M1: 09/12 11:59 PM 

 |
| 4 | 09/13 | Physics  | Milestone 2 |

M2: 09/19 11:59 PM 

 |
| 5 | 09/20 | Trespasser Case Study, Game Feel, Formal Elements |

Milestone 3,

Team Game Pitch,

 |

Team Pitch: 09/20 11:59 PM,

M3: 09/26 11:59 PM

 |
| 6 | 09/27 | AI (1-5) | Team git Exercise | Team git Ex.: 10/03 11:59 PM  |
| 7 | 10/04 | AI (6-7), Quiz 1 | Milestone 4, Quiz 1 |

Q1: 10/08 11:59 PM

M4: 10/10 11:59 PM

 |
| 8 | 10/11 |

**10/11 - 10/12 Fall Break**

Game Object Dependencies and Communication, 

 |  |  |
| 9 | 10/18 |

Prototyping, 

 |  |  |
| 10 | 10/25 |

Valve's Cabal Design Process, Playtesting

Audio 1-3

 |

Team Alpha,

Individual Team Member Assessments

 |

Course Withdrawal Deadline: Sat. 10/30 4PM EST <-- Your responsibility to double-check this deadline with the Institute calendar

Team Alpha: 10/31 11:59 PM 

Team Member Assessments: 10/31 11:59 PM 

 |
| 11 | 11/01 | Audio 4-5 |  |  |
| 12 | 11/08 |

 Interesting Choices 1-2

Interactive Narrative 1

 |  |   |
| 13 | 11/15 |

Interactive Narrative 2-3

 | Playtesting | Playtesting 11/21 11:59 PM |
| 14 | 11/22 |

Future of Games 1

**11/24-11/26 Thanksgiving**

 |  |  |
| 15 | 11/29 | Future of Games 2-5 | Quiz 2 |

 Q2: 12/03 11:59 PM

Team Project Trailer Video: 12/03 11:59 PM

Team Project Final Game: 12/05 11:59 PM

Team Project Gameplay Video: 12/05 11:59 PM 

Team Member Assessments: 12/05 11:59 PM 

 |
| 16 | 12/06 |

Final Instructional Days (12/06-12/07)

GT Finals

 | Final Deliverables |

Final Instructional Days, 

**Video trailer presentations**

 |
| 17 | 12/13 |

GT Finals

 |  |  |
