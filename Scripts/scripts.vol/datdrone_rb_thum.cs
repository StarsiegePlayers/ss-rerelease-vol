# THUMPER

#          Identity_Tag         Abbreviation Shape               Mass  MaxMass  RCS   Tech_Level   Combat_Value
droneBase( IDVEH_RB_THUM, "THUM",    "rb_thum.dts", 5.00, 30.00 ,  0.85, 2 ,          1500);

#        maxPosAcc  minPosVel  maxForPosVel  maxRevPosVel       (all_m/s)
dronePos( 15.00,    3.00,      30.00 ,       -15.50);

#         minRotVel  maxRVSlow  maxRVFast  maxRVTurret        (all_deg/s)
droneRot( 6.00,      35.00,     25.00,     65.00);

#          sphOffstX  sphOffstY  sphOffstZ  sphereRad
droneColl( 0.0,       0.0,       12.9,       13);

#          TreadAnim_Rot_Coeff  Tread_Anim_Pos_Coeff
droneAnim( 2.0,                 0.25);

#          engine_sound_tag       has_thrusters
droneSound( IDSFX_TANK_ENGINE_1,  TRUE);

newMountPoint(0, M, Body, Engine);
newMountPoint(1, M, Body, Reactor);

#            Internal     Components
#            id           type          parent  max_dmg  identity_tag
newComponent(LeftServos,  LeftServos,   none,   300.0,   IDCOM_LEFT_TREAD_SERVOS );
newComponent(RightServos, RightServos,  none,   300.0,   IDCOM_RIGHT_TREAD_SERVOS);

#             External    Components
#             id          type        parent max_dmg  identity_tag
newComponent( Body,       Body,       none,  1000.0,  IDCOM_BODY);
newComponent( LeftTread,  LeftTread,  Body,  400.0,   IDCOM_LEFT_TREAD);
newComponent( RightTread, RightTread, Body,  400.0,   IDCOM_RIGHT_TREAD);
newComponent( LeftTreadB,  LeftTreadB,  Body,  400.0,   IDCOM_LEFT_TREAD);
newComponent( RightTreadB, RightTreadB, Body,  400.0,   IDCOM_RIGHT_TREAD);

newComponent( TopPodA, TopPodA, Body,  400.0,   IDCOM_RIGHT_TREAD);
newComponent( TopPodB, TopPodB, Body,  400.0,   IDCOM_RIGHT_TREAD);


newConfiguration(LeftServos,  LeftTread,  1);
newConfiguration(RightServos, RightTread, 1);

defaultMountables(101, 200);

droneExplosion(true, 50.0);

