using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
	void Attack();
	void Death();
	void ReceiveDamage(float damage);
}
