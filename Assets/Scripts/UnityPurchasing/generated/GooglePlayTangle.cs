// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("I5ESMSMeFRo5lVuV5B4SEhIWExAwRz5ys3cPNx7pPuDSfflIY0zhUuJB/zfi9no8dpeSAYWU0weoA1yJzOh9f0MAOSDVAUHHTCtVCglCF1hY9J8X/29eWKBiBGuK7rAGBCY4xpESHBMjkRIZEZESEhOCHBVaLwge0+K1+83J362m7cvGF2a0TPmNHFQGW4Ulnt0DIodprarjdydzmdDt+9ILbZHG2WTtoItfae0HZOXbbglKgqVIK0du5nFR49Gvc7mI7bnS7lQKh7aLsSVo6Z8jlTn0f49pMMWreeroiHkAXx87IxpKAoogRUrqJZj6quha0K+Y3KLkUiFKxdcLpZbXhib//y8+7/Byi5gyFmo9hZ1QX7YzFzT702Qv/FDEEhEQEhMS");
        private static int[] order = new int[] { 0,12,4,5,10,12,7,8,12,10,11,13,12,13,14 };
        private static int key = 19;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
