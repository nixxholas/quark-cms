﻿namespace Delta.Trinity.Hotfixes
{
    public partial class VehicleSeat
    {
        public int Id { get; set; }
        public int Flags { get; set; }
        public int FlagsB { get; set; }
        public int FlagsC { get; set; }
        public float AttachmentOffsetX { get; set; }
        public float AttachmentOffsetY { get; set; }
        public float AttachmentOffsetZ { get; set; }
        public float EnterPreDelay { get; set; }
        public float EnterSpeed { get; set; }
        public float EnterGravity { get; set; }
        public float EnterMinDuration { get; set; }
        public float EnterMaxDuration { get; set; }
        public float EnterMinArcHeight { get; set; }
        public float EnterMaxArcHeight { get; set; }
        public float ExitPreDelay { get; set; }
        public float ExitSpeed { get; set; }
        public float ExitGravity { get; set; }
        public float ExitMinDuration { get; set; }
        public float ExitMaxDuration { get; set; }
        public float ExitMinArcHeight { get; set; }
        public float ExitMaxArcHeight { get; set; }
        public float PassengerYaw { get; set; }
        public float PassengerPitch { get; set; }
        public float PassengerRoll { get; set; }
        public float VehicleEnterAnimDelay { get; set; }
        public float VehicleExitAnimDelay { get; set; }
        public float CameraEnteringDelay { get; set; }
        public float CameraEnteringDuration { get; set; }
        public float CameraExitingDelay { get; set; }
        public float CameraExitingDuration { get; set; }
        public float CameraOffsetX { get; set; }
        public float CameraOffsetY { get; set; }
        public float CameraOffsetZ { get; set; }
        public float CameraPosChaseRate { get; set; }
        public float CameraFacingChaseRate { get; set; }
        public float CameraEnteringZoom { get; set; }
        public float CameraSeatZoomMin { get; set; }
        public float CameraSeatZoomMax { get; set; }
        public int UiSkinFileDataId { get; set; }
        public short EnterAnimStart { get; set; }
        public short EnterAnimLoop { get; set; }
        public short RideAnimStart { get; set; }
        public short RideAnimLoop { get; set; }
        public short RideUpperAnimStart { get; set; }
        public short RideUpperAnimLoop { get; set; }
        public short ExitAnimStart { get; set; }
        public short ExitAnimLoop { get; set; }
        public short ExitAnimEnd { get; set; }
        public short VehicleEnterAnim { get; set; }
        public short VehicleExitAnim { get; set; }
        public short VehicleRideAnimLoop { get; set; }
        public short EnterAnimKitId { get; set; }
        public short RideAnimKitId { get; set; }
        public short ExitAnimKitId { get; set; }
        public short VehicleEnterAnimKitId { get; set; }
        public short VehicleRideAnimKitId { get; set; }
        public short VehicleExitAnimKitId { get; set; }
        public short CameraModeId { get; set; }
        public byte AttachmentId { get; set; }
        public byte PassengerAttachmentId { get; set; }
        public byte VehicleEnterAnimBone { get; set; }
        public byte VehicleExitAnimBone { get; set; }
        public byte VehicleRideAnimLoopBone { get; set; }
        public byte VehicleAbilityDisplay { get; set; }
        public int EnterUisoundId { get; set; }
        public int ExitUisoundId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
