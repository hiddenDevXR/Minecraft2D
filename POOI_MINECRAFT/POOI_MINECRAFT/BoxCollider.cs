using Microsoft.Xna.Framework;

namespace POOI_MINECRAFT
{
    internal class BoxCollider
    {
        private Vector2 m_min, m_max, m_size;

        public BoxCollider() { }

        public BoxCollider(Vector2 position, Vector2 size)
        {
            m_min = position;
            m_size = size;
            m_max = m_min + size;
        }

        public void Update(Vector2 position)
        {
            m_min = position;
            m_max = m_min + m_size;
        }

        public Vector2 Min() { return m_min; }
        public Vector2 Max() { return m_max; }
    }
}
