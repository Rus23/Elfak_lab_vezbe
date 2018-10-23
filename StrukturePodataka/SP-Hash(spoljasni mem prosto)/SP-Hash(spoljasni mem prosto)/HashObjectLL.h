#pragma once
#include "HashObject.h"


class HashObjectLL
{
private:
	HashObject* head;
	HashObject* tail;

public:

	HashObjectLL()
	{
		head = tail = NULL;
	}

	bool isEmpty()
	{
		return head == NULL;
	}

	void deleteFromHead()
	{
		HashObject* tmp = head;

		if (head == tail)
			head = tail = NULL;
		else
			head = head->next;
		delete tmp;
	}

	void addToHead(char* p)
	{
		head = new HashObject(p, head);
		if (tail == NULL)
			tail = head;
	}

	bool deleteEL(char* p)
	{
		if (head->isEqual(p))
		{
			deleteFromHead();
			return 1;
		}
		else
		{
			for (HashObject* tmp = head; tmp->next != NULL&&tmp->next->isEqual(p); tmp = tmp->next)
				if (tmp->next->isEqual(p))
				{
					HashObject* pom = tmp;
					pom->next = tmp->next;
					delete tmp;
					return 1;
				}
		}
		return 0;
	}

	void print()
	{
		for (HashObject* tmp = head; tmp != NULL; tmp = tmp->next)
		{
			cout << "KEY:" << tmp->key << "; ";
		}
		cout << endl;
	}

	HashObject* find(char* p)
	{
		for (HashObject* tmp = head; tmp != NULL; tmp = tmp->next)
			if (tmp->isEqual(p))
				return tmp;
		return NULL;
	}

	~HashObjectLL()	{
		while (!isEmpty())
			deleteFromHead();
	}
};