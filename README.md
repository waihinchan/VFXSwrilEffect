# VFXSwrilEffect
use vfx make swril effect
思路是设置一个假“目标”，通过把直角坐标转成极坐标设置假目标的位置来实现粒子受到假目标的力的效果。
目前offset并不能通过transform来实现，后续会深入研究为什么transform不起作用的原因（也可能是设置错误）。
把鼠标锁在2d平面上通过射线设置offset的中心点。
