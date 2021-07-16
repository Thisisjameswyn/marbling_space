Cat like coding deformation tutorial 
  https://catlikecoding.com/unity/tutorials/mesh-deformation/


SoftBody physics using joints 
  https://www.youtube.com/watch?v=h_bSGoztB2g


Possible mesh deformation options using cloth
  https://answers.unity.com/questions/274269/mesh-deformation.html?_gl=1*jig9kq*_ga*MzY4MTI3NzQxLjE2MjMyNTkwODQ.*_ga_1S78EFL1W5*MTYyNjQ1ODA4Ni42LjAuMTYyNjQ1ODA4Ni42MA..&_ga=2.71942163.1409879953.1626458087-368127741.1623259084


Sure, there are two primary methods of simulating fluids that I read up on, particle based and height map based. Particle based gives some amazing simulation but is way to resource intensive for a real time simulation. I went the height map route for mine as it can run much faster and although more limited it covered what I needed. Look up Navier Stokes equations on google, there are a lot of different papers on it's implementation into game development, lots of variations on approach but they are all founded on the same basic principles. The maths isn't too brutal but can take a bit of work to tie into the right data structures. Great fun when it works though!

  https://www.reddit.com/r/Unity3D/comments/5w5lf2/fluid_simulation/?st=j0gs8w89&sh=a1df3d70

This might be the solution

  https://www.youtube.com/watch?v=_8v4DRhHu2g