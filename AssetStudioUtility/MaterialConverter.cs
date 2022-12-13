using System.Text;

namespace AssetStudio
{
    public static class MaterialConverter
    {
        public static string Convert(this Material material)
        {
            StringBuilder sb = new StringBuilder();

            if (material.m_Shader != null)
            {
                sb.AppendLine("Shader PathId = " + material.m_Shader.m_PathID);
                sb.AppendLine("");
            }

            if (material.m_SavedProperties.m_TexEnvs != null)
            {
                sb.AppendLine("Textures --- ");
                foreach (var texparams in material.m_SavedProperties.m_TexEnvs)
                {
                    sb.AppendLine(texparams.Key + " - ");
                    sb.AppendLine("PathId = " + texparams.Value.m_Texture.m_PathID);
                    sb.AppendLine("Scale = X" + texparams.Value.m_Scale.X + ", Y" + texparams.Value.m_Scale.Y);
                    sb.AppendLine("Offset = X" + texparams.Value.m_Offset.X + ", Y" + texparams.Value.m_Offset.Y);
                    sb.AppendLine("");
                }
            }

            if (material.m_SavedProperties.m_Ints != null)
            {
                sb.AppendLine("Integers --- ");
                foreach (var intparams in material.m_SavedProperties.m_Ints)
                {
                    sb.AppendLine(intparams.Key + " = " + intparams.Value);
                }
                sb.AppendLine("");
            }

            if (material.m_SavedProperties.m_Floats != null)
            {
                sb.AppendLine("Floats --- ");
                foreach (var floatparams in material.m_SavedProperties.m_Floats)
                {
                    sb.AppendLine(floatparams.Key + " = " + floatparams.Value);
                }
                sb.AppendLine("");
            }

            if (material.m_SavedProperties.m_Colors != null)
            {
                sb.AppendLine("Colours --- ");
                foreach (var colparams in material.m_SavedProperties.m_Colors)
                {
                    sb.AppendLine(colparams.Key + " = " + colparams.Value.R + " " + colparams.Value.G + " " + colparams.Value.B + " " + colparams.Value.A);
                }
                sb.AppendLine("");
            }
            return sb.ToString();
        }
    }
}
