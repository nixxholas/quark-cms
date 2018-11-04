namespace Delta.Trinity.Hotfixes
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public int Flags { get; set; }
        public float TurnSpeed { get; set; }
        public float PitchSpeed { get; set; }
        public float PitchMin { get; set; }
        public float PitchMax { get; set; }
        public float MouseLookOffsetPitch { get; set; }
        public float CameraFadeDistScalarMin { get; set; }
        public float CameraFadeDistScalarMax { get; set; }
        public float CameraPitchOffset { get; set; }
        public float FacingLimitRight { get; set; }
        public float FacingLimitLeft { get; set; }
        public float CameraYawOffset { get; set; }
        public short SeatId1 { get; set; }
        public short SeatId2 { get; set; }
        public short SeatId3 { get; set; }
        public short SeatId4 { get; set; }
        public short SeatId5 { get; set; }
        public short SeatId6 { get; set; }
        public short SeatId7 { get; set; }
        public short SeatId8 { get; set; }
        public short VehicleUiindicatorId { get; set; }
        public short PowerDisplayId1 { get; set; }
        public short PowerDisplayId2 { get; set; }
        public short PowerDisplayId3 { get; set; }
        public byte FlagsB { get; set; }
        public byte UiLocomotionType { get; set; }
        public int MissileTargetingId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
